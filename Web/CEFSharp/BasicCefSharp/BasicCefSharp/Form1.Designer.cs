namespace BasicCefSharp
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpGraduation = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.cbxOccupation = new System.Windows.Forms.ComboBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblGraduation = new System.Windows.Forms.Label();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // dtpGraduation
            // 
            this.dtpGraduation.CustomFormat = "";
            this.dtpGraduation.Location = new System.Drawing.Point(83, 65);
            this.dtpGraduation.Name = "dtpGraduation";
            this.dtpGraduation.Size = new System.Drawing.Size(183, 20);
            this.dtpGraduation.TabIndex = 5;
            this.dtpGraduation.ValueChanged += new System.EventHandler(this.dtpGraduation_ValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // cbxOccupation
            // 
            this.cbxOccupation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOccupation.FormattingEnabled = true;
            this.cbxOccupation.Items.AddRange(new object[] {
            "Brand Evangelist",
            "Dynamic Web Mystic",
            "Emergent Media Maker",
            "Global Talent Supplier",
            "Happiness Mindset Exec",
            "Head of Mobility Dude",
            "Innovation Sherpa",
            "Information Advisor",
            "Zen Cloud Deputy"});
            this.cbxOccupation.Location = new System.Drawing.Point(83, 38);
            this.cbxOccupation.Name = "cbxOccupation";
            this.cbxOccupation.Size = new System.Drawing.Size(183, 21);
            this.cbxOccupation.TabIndex = 6;
            this.cbxOccupation.SelectedIndexChanged += new System.EventHandler(this.cbxOccupation_SelectedIndexChanged);
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(12, 41);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(65, 13);
            this.lblOccupation.TabIndex = 7;
            this.lblOccupation.Text = "Occupation:";
            // 
            // lblGraduation
            // 
            this.lblGraduation.AutoSize = true;
            this.lblGraduation.Location = new System.Drawing.Point(12, 68);
            this.lblGraduation.Name = "lblGraduation";
            this.lblGraduation.Size = new System.Drawing.Size(62, 13);
            this.lblGraduation.TabIndex = 8;
            this.lblGraduation.Text = "Graduation:";
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(291, 12);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(380, 226);
            this.chromiumWebBrowser1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 250);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.lblGraduation);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.cbxOccupation);
            this.Controls.Add(this.dtpGraduation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MinimumSize = new System.Drawing.Size(700, 289);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpGraduation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxOccupation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblGraduation;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
    }
}

