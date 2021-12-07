using System.Windows.Forms;

namespace MessageBoxForDevs
{
    partial class ExceptionalBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionalBox));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSOS = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMS = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnNote = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(177, 92);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnSOS
            // 
            this.btnSOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSOS.ImageKey = "so.png";
            this.btnSOS.ImageList = this.imageList1;
            this.btnSOS.Location = new System.Drawing.Point(296, 92);
            this.btnSOS.Name = "btnSOS";
            this.btnSOS.Size = new System.Drawing.Size(24, 24);
            this.btnSOS.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnSOS, "Search error on StackOverflow");
            this.btnSOS.UseVisualStyleBackColor = false;
            this.btnSOS.Visible = false;
            this.btnSOS.Click += new System.EventHandler(this.btnSOS_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "copy.png");
            this.imageList1.Images.SetKeyName(1, "ms.png");
            this.imageList1.Images.SetKeyName(2, "pad.png");
            this.imageList1.Images.SetKeyName(3, "so.png");
            // 
            // btnMS
            // 
            this.btnMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMS.ImageKey = "ms.png";
            this.btnMS.ImageList = this.imageList1;
            this.btnMS.Location = new System.Drawing.Point(326, 92);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(24, 23);
            this.btnMS.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnMS, "Search error on MSDN");
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Visible = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.ImageKey = "copy.png";
            this.btnCopy.ImageList = this.imageList1;
            this.btnCopy.Location = new System.Drawing.Point(356, 92);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(24, 23);
            this.btnCopy.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCopy, "Copy exception to clipboard");
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(404, 80);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Your error message goes here.";
            // 
            // btnNote
            // 
            this.btnNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNote.ImageKey = "pad.png";
            this.btnNote.ImageList = this.imageList1;
            this.btnNote.Location = new System.Drawing.Point(386, 92);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(24, 23);
            this.btnNote.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnNote, "Open exception in Notepad");
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Visible = false;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // ExceptionalBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(428, 127);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnSOS);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExceptionalBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Womp Womp!";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOK;
        private Button btnSOS;
        private Button btnMS;
        private Button btnCopy;
        private Label lblMessage;
        private Button btnNote;
        private ToolTip toolTip1;
        private ImageList imageList1;
    }
}