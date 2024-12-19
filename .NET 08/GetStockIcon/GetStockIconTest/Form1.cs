using System.Linq;

namespace GetStockIconTest;

public partial class Form1 : Form
{
    readonly Bitmap connImg;
    readonly Bitmap disconnImg;

    public Form1()
    {
        InitializeComponent();

        connImg = SystemIcons.GetStockIcon(StockIconId.DriveNet, 128).ToBitmap();
        disconnImg = SystemIcons.GetStockIcon(StockIconId.DriveNetDisabled, 128).ToBitmap();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        connImg.Dispose();
        disconnImg.Dispose();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        lboxSaveIcons.SelectedIndex = 0;

        // Populate image list with default size, which should be 32 px
        imageList1.Images.Add("Conn", SystemIcons.GetStockIcon(StockIconId.DriveNet));
        imageList1.Images.Add("Disconn", SystemIcons.GetStockIcon(StockIconId.DriveNetDisabled));

        button1.ImageKey = "Conn";
        pictureBox1.Image = connImg;

        // Populate another image list with 64 px size
        foreach (StockIconId icon in Enum.GetValues(typeof(StockIconId)))
            imageList2.Images.Add(icon.ToString(), SystemIcons.GetStockIcon(icon, 64));

        // Then use the icons in the second list to populate the toolbar
        // and generate a bunch of pictures with the icon at the larger size
        foreach (var imageKey in imageList2.Images.Keys)
        {
            var btn = new ToolStripButton(imageList2.Images[imageKey]);
            btn.Click += (s, e) => MessageBox.Show($"Stock Icon: {imageKey}");
            btn.Image = imageList2.Images[imageKey];
            btn.ToolTipText = imageKey;
            toolStrip1.Items.Add(btn);

            var pb = new PictureBox
            {
                Width = 64, Height = 64,
                Image = imageList2.Images[imageKey]
            };
            toolTip1.SetToolTip(pb, imageKey);
            flowLayoutPanel1.Controls.Add(pb);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Toggle between two icons
        if (button1.ImageKey == "Conn")
        {
            button1.ImageKey = "Disconn";
            button1.Text = "Disconnected";
            pictureBox1.Image = disconnImg;
        }
        else
        {
            button1.ImageKey = "Conn";
            button1.Text = "Connected";
            pictureBox1.Image = connImg;
        }
    }

    private void btnSaveIcons_Click(object sender, EventArgs e)
    {
        // Save all icons in .ico format (which looks ugly)
        // and in .bmp format (which looks great) 
        var result = folderBrowserDialog1.ShowDialog();
        if (result == DialogResult.OK)
        {
            var savePath = folderBrowserDialog1.SelectedPath;
            foreach (StockIconId icon in Enum.GetValues(typeof(StockIconId)))
            {
                var stockIcon = SystemIcons.GetStockIcon(icon, Convert.ToInt32(lboxSaveIcons.SelectedItem));

                // Save .bmp file
                stockIcon.ToBitmap().Save(Path.Combine(savePath, $"{icon}.bmp"));
             
                // Save .ico file
                using FileStream fs = new(Path.Combine(savePath, $"{icon}.ico"), FileMode.Create);
                stockIcon.Save(fs);
            }
        }
    }
}
