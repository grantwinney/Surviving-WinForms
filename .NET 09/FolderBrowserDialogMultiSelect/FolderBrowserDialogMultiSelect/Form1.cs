namespace FolderBrowserDialogMultiSelect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            fbd.Multiselect = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
                MessageBox.Show($"The path(s) to process:\n\n{string.Join("\n", fbd.SelectedPaths)}");
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            fbd.Multiselect = rdoYes.Checked;
        }
    }
}
