namespace FolderBrowserDialogOriginal
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
            fbd = new FolderBrowserDialog();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.None;
            btnSelect.Location = new Point(155, 109);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 43);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "&Select Folder";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(btnSelect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog fbd;
        private Button btnSelect;
    }
}
