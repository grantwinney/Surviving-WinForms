namespace FolderBrowserDialogMultiSelect
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
            rdoYes = new RadioButton();
            rdoNo = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top;
            btnSelect.Location = new Point(155, 109);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 43);
            btnSelect.TabIndex = 3;
            btnSelect.Text = "&Select Folders";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // rdoYes
            // 
            rdoYes.Anchor = AnchorStyles.Top;
            rdoYes.AutoSize = true;
            rdoYes.Checked = true;
            rdoYes.Location = new Point(143, 73);
            rdoYes.Name = "rdoYes";
            rdoYes.Size = new Size(42, 19);
            rdoYes.TabIndex = 4;
            rdoYes.TabStop = true;
            rdoYes.Text = "&Yes";
            rdoYes.UseVisualStyleBackColor = true;
            rdoYes.CheckedChanged += rdoYes_CheckedChanged;
            // 
            // rdoNo
            // 
            rdoNo.Anchor = AnchorStyles.Top;
            rdoNo.AutoSize = true;
            rdoNo.Location = new Point(205, 73);
            rdoNo.Name = "rdoNo";
            rdoNo.Size = new Size(41, 19);
            rdoNo.TabIndex = 5;
            rdoNo.Text = "No";
            rdoNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(143, 44);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 6;
            label1.Text = "Allow multiselect?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(label1);
            Controls.Add(rdoNo);
            Controls.Add(rdoYes);
            Controls.Add(btnSelect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog fbd;
        private Button btnSelect;
        private RadioButton rdoYes;
        private RadioButton rdoNo;
        private Label label1;
    }
}
