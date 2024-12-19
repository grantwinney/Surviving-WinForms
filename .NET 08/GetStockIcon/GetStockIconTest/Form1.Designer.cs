namespace GetStockIconTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            imageList1 = new ImageList(components);
            toolStrip1 = new ToolStrip();
            imageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            toolTip1 = new ToolTip(components);
            btnSaveIcons = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            lboxSaveIcons = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageList = imageList1;
            button1.Location = new Point(15, 138);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 0;
            button1.Text = "Connected";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // toolStrip1
            // 
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(877, 0);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(64, 64);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(167, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 268);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(877, 311);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnSaveIcons
            // 
            btnSaveIcons.Location = new Point(634, 138);
            btnSaveIcons.Name = "btnSaveIcons";
            btnSaveIcons.Size = new Size(75, 23);
            btnSaveIcons.TabIndex = 5;
            btnSaveIcons.Text = "Save Icons";
            toolTip1.SetToolTip(btnSaveIcons, "Save icons in .ico/.bmp formats");
            btnSaveIcons.UseVisualStyleBackColor = true;
            btnSaveIcons.Click += btnSaveIcons_Click;
            // 
            // lboxSaveIcons
            // 
            lboxSaveIcons.FormattingEnabled = true;
            lboxSaveIcons.ItemHeight = 15;
            lboxSaveIcons.Items.AddRange(new object[] { "16", "32", "64", "128", "256" });
            lboxSaveIcons.Location = new Point(583, 94);
            lboxSaveIcons.Name = "lboxSaveIcons";
            lboxSaveIcons.Size = new Size(35, 94);
            lboxSaveIcons.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 579);
            Controls.Add(lboxSaveIcons);
            Controls.Add(btnSaveIcons);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Controls.Add(button1);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ToolStrip toolStrip1;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolTip toolTip1;
        private Button btnSaveIcons;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox lboxSaveIcons;
    }
}
