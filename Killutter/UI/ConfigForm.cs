using Killutter.Modules.DownloadsOrganizer;
using Killutter.Shared;

namespace Killutter.UI
{
    public partial class ConfigForm : Form
    {
        private Config config;

        public ConfigForm(Config config)
        {
            InitializeComponent();
            this.config = config;

            ChangeWatchPath.Click += ChangeWatchPath_Click;
            ChangeLogPath.Click += ChangeLogPath_Click;
            AddGroup.Click += AddGroup_Click;

            addGroupControl1.SaveClicked += AddGroupControl1_SaveClicked;
            addGroupControl1.CancelClicked += AddGroupControl1_CancelClicked;
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            Watchpath.Text = config.GetWatchFolder();
            Logpath.Text = config.GetLogPath();
            RunAtStartup.Checked = TaskRegistrar.IsRegistered();

            RefreshGroupList();
        }

        private void RefreshGroupList()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Group g in config.GetGroups())
            {
                GroupCard card = new GroupCard();
                card.SetGroup(g);
                card.DeleteClicked += (s, e) => DeleteGroup(g);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void DeleteGroup(Group g)
        {
            config.DeleteGroup(g.Id);
            config.Save();
            RefreshGroupList();
        }

        private void ChangeWatchPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    config.SetWatchFolder(dialog.SelectedPath);
                    config.Save();
                    Watchpath.Text = dialog.SelectedPath;
                }
            }
        }

        private void ChangeLogPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = System.IO.Path.Combine(dialog.SelectedPath, "Killutter.log");
                    config.SetLogPath(path);
                    config.Save();
                    Logpath.Text = path;
                    Logger.SetLogPath(path);
                }
            }
        }
        private void WatchfolderLabel_Click(object sender, EventArgs e)
        {
            // decorative label click — no action needed
        }

        private void LogFolderIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string folder = System.IO.Path.GetDirectoryName(config.GetLogPath());
            if (System.IO.Directory.Exists(folder))
                System.Diagnostics.Process.Start("explorer.exe", folder);
        }

        private void RunAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (RunAtStartup.Checked)
                TaskRegistrar.Register();
            else
                TaskRegistrar.UnRegister();
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            ShowAddGroup(true);
        }

        private void ShowAddGroup(bool show)
        {
            addGroupControl1.Visible = show;
            flowLayoutPanel1.Visible = !show;
            AddGroup.Enabled = !show;
        }

        private void AddGroupControl1_SaveClicked(object sender, EventArgs e)
        {
            config.AddGroup(
                addGroupControl1.GetGroupName(),
                addGroupControl1.GetDestinationPath(),
                addGroupControl1.GetCheckedTypes());
            config.Save();

            addGroupControl1.Reset();
            ShowAddGroup(false);
            RefreshGroupList();
        }

        private void AddGroupControl1_CancelClicked(object sender, EventArgs e)
        {
            addGroupControl1.Reset();
            ShowAddGroup(false);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void groupCard1_Load(object sender, EventArgs e)
        {

        }

        private void AddGroup_Click_1(object sender, EventArgs e)
        {

        }

        private void ChangeWatchPath_Click_1(object sender, EventArgs e)
        {

        }
    }
}