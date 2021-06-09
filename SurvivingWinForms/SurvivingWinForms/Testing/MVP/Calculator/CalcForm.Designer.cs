namespace SurvivingWinForms.Testing.MVP.Calculator
{
    partial class CalcForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRunningTotal = new System.Windows.Forms.Label();
            this.txtRunningTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 49);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(26, 26);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(308, 22);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(26, 106);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(308, 22);
            this.txtNumber3.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(26, 147);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(308, 34);
            this.txtTotal.TabIndex = 3;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(26, 64);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(308, 22);
            this.txtNumber2.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(213, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 49);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblRunningTotal
            // 
            this.lblRunningTotal.AutoSize = true;
            this.lblRunningTotal.Location = new System.Drawing.Point(401, 68);
            this.lblRunningTotal.Name = "lblRunningTotal";
            this.lblRunningTotal.Size = new System.Drawing.Size(101, 17);
            this.lblRunningTotal.TabIndex = 6;
            this.lblRunningTotal.Text = "Running Total:";
            // 
            // txtRunningTotal
            // 
            this.txtRunningTotal.Location = new System.Drawing.Point(402, 97);
            this.txtRunningTotal.Name = "txtRunningTotal";
            this.txtRunningTotal.ReadOnly = true;
            this.txtRunningTotal.Size = new System.Drawing.Size(248, 22);
            this.txtRunningTotal.TabIndex = 7;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 297);
            this.Controls.Add(this.txtRunningTotal);
            this.Controls.Add(this.lblRunningTotal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnAdd);
            this.Name = "CalcForm";
            this.Text = "Calculator v0.01a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRunningTotal;
        private System.Windows.Forms.TextBox txtRunningTotal;
    }
}

