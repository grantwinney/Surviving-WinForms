namespace FolderBrowserDialogOriginal;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnSelect_Click(object sender, EventArgs e)
    {
        if (fbd.ShowDialog() == DialogResult.OK)
            MessageBox.Show($"The path to process:\n\n{fbd.SelectedPath}");
    }
}
