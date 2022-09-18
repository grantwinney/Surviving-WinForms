namespace StringInterpolation
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.numLuckyNumber = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.lblSurvey = new System.Windows.Forms.Label();
            this.cboBeverage = new System.Windows.Forms.ComboBox();
            this.lblBeverage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLuckyNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Location = new System.Drawing.Point(8, 51);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(48, 13);
            this.lblBday.TabIndex = 2;
            this.lblBday.Text = "Birthday:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(78, 48);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 3;
            // 
            // numLuckyNumber
            // 
            this.numLuckyNumber.Location = new System.Drawing.Point(170, 85);
            this.numLuckyNumber.Name = "numLuckyNumber";
            this.numLuckyNumber.Size = new System.Drawing.Size(108, 20);
            this.numLuckyNumber.TabIndex = 5;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(8, 87);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(98, 13);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Your lucky number:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(203, 195);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Location = new System.Drawing.Point(170, 120);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(43, 17);
            this.rdoYes.TabIndex = 7;
            this.rdoYes.TabStop = true;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Location = new System.Drawing.Point(219, 120);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(39, 17);
            this.rdoNo.TabIndex = 8;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            // 
            // lblSurvey
            // 
            this.lblSurvey.AutoSize = true;
            this.lblSurvey.Location = new System.Drawing.Point(8, 122);
            this.lblSurvey.Name = "lblSurvey";
            this.lblSurvey.Size = new System.Drawing.Size(144, 13);
            this.lblSurvey.TabIndex = 6;
            this.lblSurvey.Text = "Are you surviving WinForms?";
            // 
            // cboBeverage
            // 
            this.cboBeverage.FormattingEnabled = true;
            this.cboBeverage.Items.AddRange(new object[] {
            "Pop",
            "Beer",
            "Wine",
            "Milk",
            "Orange Juice",
            "Water"});
            this.cboBeverage.Location = new System.Drawing.Point(128, 153);
            this.cboBeverage.Name = "cboBeverage";
            this.cboBeverage.Size = new System.Drawing.Size(150, 21);
            this.cboBeverage.TabIndex = 10;
            // 
            // lblBeverage
            // 
            this.lblBeverage.AutoSize = true;
            this.lblBeverage.Location = new System.Drawing.Point(8, 156);
            this.lblBeverage.Name = "lblBeverage";
            this.lblBeverage.Size = new System.Drawing.Size(101, 13);
            this.lblBeverage.TabIndex = 9;
            this.lblBeverage.Text = "Preferred beverage:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(11, 246);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(267, 79);
            this.txtMessage.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 340);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblBeverage);
            this.Controls.Add(this.cboBeverage);
            this.Controls.Add(this.lblSurvey);
            this.Controls.Add(this.rdoNo);
            this.Controls.Add(this.rdoYes);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.numLuckyNumber);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblBday);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Interpolate those strings";
            ((System.ComponentModel.ISupportInitialize)(this.numLuckyNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.NumericUpDown numLuckyNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.Label lblSurvey;
        private System.Windows.Forms.ComboBox cboBeverage;
        private System.Windows.Forms.Label lblBeverage;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

