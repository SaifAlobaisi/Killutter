namespace Killutter.UI
{
    public partial class AddGroupControl : UserControl
    {
        private string destinationPath;
        private string defaultDestText;

        public event EventHandler SaveClicked;
        public event EventHandler CancelClicked;

        public AddGroupControl()
        {
            InitializeComponent();

            defaultDestText = DestValueLabel.Text;

            Browse.Click += Browse_Click;
            Save.Click += Save_Click;
            CancelButton.Click += CancelButton_Click;
        }

        private CheckBox[] AllBoxes()
        {
            return new CheckBox[]
            {
        PdfCheck, DocxCheck, PptxCheck, XlsxCheck,
        JpegCheck, PngCheck, GifCheck,
        Mp3Check,
        TxtCheck, CsvCheck, MdCheck, LogCheck,
        JsonCheck, PyCheck, JsCheck,
        ZipCheck, GzipCheck, JarCheck,
        ExeCheck, ApkCheck
            };
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    destinationPath = dialog.SelectedPath;
                    DestValueLabel.Text = destinationPath;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Enter a group name.", "Missing name");
                return;
            }

            if (string.IsNullOrEmpty(destinationPath))
            {
                MessageBox.Show("Choose a destination folder.", "Missing destination");
                return;
            }

            if (GetCheckedTypes().Count == 0)
            {
                MessageBox.Show("Select at least one file type.", "Missing types");
                return;
            }

            SaveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }

        public string GetGroupName()
        {
            return NameTextBox.Text.Trim();
        }

        public string GetDestinationPath()
        {
            return destinationPath;
        }

        public List<string> GetCheckedTypes()
        {
            List<string> types = new List<string>();
            foreach (CheckBox box in AllBoxes())
                if (box.Checked)
                    types.Add(box.Text);
            return types;
        }

        public void Reset()
        {
            NameTextBox.Text = "";
            destinationPath = null;
            DestValueLabel.Text = defaultDestText;
            foreach (CheckBox box in AllBoxes())
                box.Checked = false;
        }

        private void Browse_Click_1(object sender, EventArgs e)
        {

        }

        private void Save_Click_1(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}