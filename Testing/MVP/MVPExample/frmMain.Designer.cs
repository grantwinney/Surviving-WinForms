
namespace MVPExample
{
    partial class frmMain
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
            this.btnLaunchCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaunchCalculator
            // 
            this.btnLaunchCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchCalculator.Location = new System.Drawing.Point(61, 77);
            this.btnLaunchCalculator.Name = "btnLaunchCalculator";
            this.btnLaunchCalculator.Size = new System.Drawing.Size(445, 100);
            this.btnLaunchCalculator.TabIndex = 0;
            this.btnLaunchCalculator.Text = "Launch Calculator";
            this.btnLaunchCalculator.UseVisualStyleBackColor = true;
            this.btnLaunchCalculator.Click += new System.EventHandler(this.btnLaunchCalculator_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 259);
            this.Controls.Add(this.btnLaunchCalculator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchCalculator;
    }
}