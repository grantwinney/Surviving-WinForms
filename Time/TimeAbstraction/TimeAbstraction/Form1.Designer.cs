namespace TimeAbstraction
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCurrentTimeOnce = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCurrentTimeUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRefreshTime = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslCurrentTimeOnce,
            this.toolStripStatusLabel2,
            this.tslCurrentTimeUpdate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 194);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(466, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 17);
            this.toolStripStatusLabel1.Text = "Current Time (set once):";
            // 
            // tslCurrentTimeOnce
            // 
            this.tslCurrentTimeOnce.Name = "tslCurrentTimeOnce";
            this.tslCurrentTimeOnce.Size = new System.Drawing.Size(70, 17);
            this.tslCurrentTimeOnce.Text = "12:34:56 PM";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(147, 17);
            this.toolStripStatusLabel2.Text = "     Current Time (updates):";
            // 
            // tslCurrentTimeUpdate
            // 
            this.tslCurrentTimeUpdate.Name = "tslCurrentTimeUpdate";
            this.tslCurrentTimeUpdate.Size = new System.Drawing.Size(70, 17);
            this.tslCurrentTimeUpdate.Text = "12:34:56 PM";
            // 
            // btnRefreshTime
            // 
            this.btnRefreshTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshTime.Location = new System.Drawing.Point(44, 138);
            this.btnRefreshTime.Name = "btnRefreshTime";
            this.btnRefreshTime.Size = new System.Drawing.Size(98, 23);
            this.btnRefreshTime.TabIndex = 1;
            this.btnRefreshTime.Text = "▼ Update Me ▼";
            this.btnRefreshTime.UseVisualStyleBackColor = true;
            this.btnRefreshTime.Click += new System.EventHandler(this.btnRefreshTime_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(13, 13);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(441, 56);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 216);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnRefreshTime);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(480, 250);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslCurrentTimeOnce;
        private System.Windows.Forms.ToolStripStatusLabel tslCurrentTimeUpdate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnRefreshTime;
        private System.Windows.Forms.Label lblDiscount;
    }
}

