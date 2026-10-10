namespace Killutter.UI
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Watchpath = new Label();
            Watchfolder = new Label();
            Logfile = new Label();
            Logpath = new Label();
            Foldericon = new LinkLabel();
            linkLabel1 = new LinkLabel();
            RunAtStartup = new CheckBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            addGroupControl1 = new AddGroupControl();
            groupCard1 = new GroupCard();
            ChangeWatchPath = new ReaLTaiizor.Controls.Button();
            ChangeLogPath = new ReaLTaiizor.Controls.Button();
            AddGroup = new ReaLTaiizor.Controls.Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Watchpath
            // 
            Watchpath.AutoSize = true;
            Watchpath.ForeColor = SystemColors.ButtonFace;
            Watchpath.Location = new Point(102, 48);
            Watchpath.Name = "Watchpath";
            Watchpath.Size = new Size(40, 15);
            Watchpath.TabIndex = 0;
            Watchpath.Text = "Path...";
            // 
            // Watchfolder
            // 
            Watchfolder.AutoSize = true;
            Watchfolder.ForeColor = Color.FromArgb(138, 138, 138);
            Watchfolder.Location = new Point(92, 21);
            Watchfolder.Name = "Watchfolder";
            Watchfolder.Size = new Size(75, 15);
            Watchfolder.TabIndex = 1;
            Watchfolder.Text = "Watch folder";
            Watchfolder.Click += WatchfolderLabel_Click;
            // 
            // Logfile
            // 
            Logfile.AutoSize = true;
            Logfile.ForeColor = Color.FromArgb(138, 138, 138);
            Logfile.Location = new Point(92, 83);
            Logfile.Name = "Logfile";
            Logfile.Size = new Size(46, 15);
            Logfile.TabIndex = 3;
            Logfile.Text = "Log file";
            // 
            // Logpath
            // 
            Logpath.AutoSize = true;
            Logpath.ForeColor = SystemColors.ButtonFace;
            Logpath.Location = new Point(102, 110);
            Logpath.Name = "Logpath";
            Logpath.Size = new Size(40, 15);
            Logpath.TabIndex = 6;
            Logpath.Text = "Path...";
            // 
            // Foldericon
            // 
            Foldericon.ActiveLinkColor = Color.FromArgb(48, 48, 48);
            Foldericon.AutoSize = true;
            Foldericon.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Foldericon.LinkColor = Color.FromArgb(64, 64, 64);
            Foldericon.Location = new Point(23, 20);
            Foldericon.Name = "Foldericon";
            Foldericon.Size = new Size(63, 43);
            Foldericon.TabIndex = 9;
            Foldericon.TabStop = true;
            Foldericon.Text = "📁";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(48, 48, 48);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(23, 87);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 43);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "📁";
            linkLabel1.LinkClicked += LogFolderIcon_LinkClicked;
            // 
            // RunAtStartup
            // 
            RunAtStartup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RunAtStartup.AutoSize = true;
            RunAtStartup.Font = new Font("Segoe UI", 12F);
            RunAtStartup.ForeColor = Color.FromArgb(138, 138, 138);
            RunAtStartup.Location = new Point(23, 696);
            RunAtStartup.Name = "RunAtStartup";
            RunAtStartup.Size = new Size(130, 25);
            RunAtStartup.TabIndex = 14;
            RunAtStartup.Text = "Run At Startup";
            RunAtStartup.UseVisualStyleBackColor = true;
            RunAtStartup.CheckedChanged += RunAtStartup_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(24, 24, 24);
            panel1.Controls.Add(addGroupControl1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(23, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 509);
            panel1.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(groupCard1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(878, 509);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // addGroupControl1
            // 
            addGroupControl1.BackColor = Color.FromArgb(30, 30, 30);
            addGroupControl1.Dock = DockStyle.Fill;
            addGroupControl1.Location = new Point(0, 0);
            addGroupControl1.Name = "addGroupControl1";
            addGroupControl1.Size = new Size(878, 509);
            addGroupControl1.TabIndex = 1;
            addGroupControl1.Visible = false;
            // 
            // groupCard1
            // 
            groupCard1.BackColor = Color.FromArgb(43, 43, 43);
            groupCard1.ForeColor = SystemColors.ControlText;
            groupCard1.Location = new Point(3, 3);
            groupCard1.Name = "groupCard1";
            groupCard1.Size = new Size(429, 174);
            groupCard1.TabIndex = 0;
            groupCard1.Load += groupCard1_Load;
            // 
            // ChangeWatchPath
            // 
            ChangeWatchPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChangeWatchPath.BackColor = Color.Transparent;
            ChangeWatchPath.BorderColor = Color.FromArgb(0, 98, 204);
            ChangeWatchPath.EnteredBorderColor = Color.FromArgb(0, 98, 204);
            ChangeWatchPath.EnteredColor = Color.FromArgb(0, 105, 217);
            ChangeWatchPath.Font = new Font("Microsoft Sans Serif", 12F);
            ChangeWatchPath.Image = null;
            ChangeWatchPath.ImageAlign = ContentAlignment.MiddleLeft;
            ChangeWatchPath.InactiveColor = Color.FromArgb(0, 123, 255);
            ChangeWatchPath.Location = new Point(807, 21);
            ChangeWatchPath.Name = "ChangeWatchPath";
            ChangeWatchPath.PressedBorderColor = Color.FromArgb(0, 98, 204);
            ChangeWatchPath.PressedColor = Color.FromArgb(0, 98, 204);
            ChangeWatchPath.Size = new Size(94, 42);
            ChangeWatchPath.TabIndex = 7;
            ChangeWatchPath.Text = "Change...";
            ChangeWatchPath.TextAlignment = StringAlignment.Center;
            // 
            // ChangeLogPath
            // 
            ChangeLogPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChangeLogPath.BackColor = Color.Transparent;
            ChangeLogPath.BorderColor = Color.FromArgb(0, 98, 204);
            ChangeLogPath.EnteredBorderColor = Color.FromArgb(0, 98, 204);
            ChangeLogPath.EnteredColor = Color.FromArgb(0, 105, 217);
            ChangeLogPath.Font = new Font("Microsoft Sans Serif", 12F);
            ChangeLogPath.Image = null;
            ChangeLogPath.ImageAlign = ContentAlignment.MiddleLeft;
            ChangeLogPath.InactiveColor = Color.FromArgb(0, 123, 255);
            ChangeLogPath.Location = new Point(807, 83);
            ChangeLogPath.Name = "ChangeLogPath";
            ChangeLogPath.PressedBorderColor = Color.FromArgb(0, 98, 204);
            ChangeLogPath.PressedColor = Color.FromArgb(0, 98, 204);
            ChangeLogPath.Size = new Size(94, 42);
            ChangeLogPath.TabIndex = 8;
            ChangeLogPath.Text = "Change...";
            ChangeLogPath.TextAlignment = StringAlignment.Center;
            // 
            // AddGroup
            // 
            AddGroup.BackColor = Color.Transparent;
            AddGroup.BorderColor = Color.FromArgb(0, 98, 204);
            AddGroup.EnteredBorderColor = Color.FromArgb(0, 98, 204);
            AddGroup.EnteredColor = Color.FromArgb(0, 105, 217);
            AddGroup.Font = new Font("Microsoft Sans Serif", 12F);
            AddGroup.Image = null;
            AddGroup.ImageAlign = ContentAlignment.MiddleLeft;
            AddGroup.InactiveColor = Color.FromArgb(0, 123, 255);
            AddGroup.Location = new Point(807, 679);
            AddGroup.Name = "AddGroup";
            AddGroup.PressedBorderColor = Color.FromArgb(0, 98, 204);
            AddGroup.PressedColor = Color.FromArgb(0, 98, 204);
            AddGroup.Size = new Size(94, 42);
            AddGroup.TabIndex = 11;
            AddGroup.Text = "Add Group";
            AddGroup.TextAlignment = StringAlignment.Center;
            AddGroup.Click += AddGroup_Click;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(924, 736);
            Controls.Add(AddGroup);
            Controls.Add(ChangeLogPath);
            Controls.Add(ChangeWatchPath);
            Controls.Add(panel1);
            Controls.Add(RunAtStartup);
            Controls.Add(linkLabel1);
            Controls.Add(Foldericon);
            Controls.Add(Logpath);
            Controls.Add(Logfile);
            Controls.Add(Watchfolder);
            Controls.Add(Watchpath);
            Name = "ConfigForm";
            Text = "Killutter";
            Load += ConfigForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Watchpath;
        private Label Watchfolder;
        private Label Logfile;
        private Label Logpath;
        private LinkLabel Foldericon;
        private LinkLabel linkLabel1;
        private CheckBox RunAtStartup;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupCard groupCard1;
        private ReaLTaiizor.Controls.Button ChangeWatchPath;
        private ReaLTaiizor.Controls.Button ChangeLogPath;
        private ReaLTaiizor.Controls.Button AddGroup;
        private AddGroupControl addGroupControl1;
    }
}