
namespace SurvivingWinForms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsThreadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncAwaitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsiveUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThreadingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsThreadingToolStripMenuItem
            // 
            this.tsThreadingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asyncAwaitToolStripMenuItem});
            this.tsThreadingToolStripMenuItem.Name = "tsThreadingToolStripMenuItem";
            this.tsThreadingToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.tsThreadingToolStripMenuItem.Text = "Threading";
            // 
            // asyncAwaitToolStripMenuItem
            // 
            this.asyncAwaitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.responsiveUIToolStripMenuItem});
            this.asyncAwaitToolStripMenuItem.Name = "asyncAwaitToolStripMenuItem";
            this.asyncAwaitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asyncAwaitToolStripMenuItem.Text = "Async / Await";
            // 
            // responsiveModalToolStripMenuItem
            // 
            this.responsiveUIToolStripMenuItem.Name = "responsiveUIToolStripMenuItem";
            this.responsiveUIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.responsiveUIToolStripMenuItem.Text = "Responsive UI";
            this.responsiveUIToolStripMenuItem.Click += new System.EventHandler(this.responsiveUIToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsThreadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncAwaitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsiveUIToolStripMenuItem;
    }
}

