﻿
namespace SurvivingWinForms.Threading.AsyncAwait.ResponsiveUI
{
    partial class frmResponsiveModal
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
            this.btnMainThread = new System.Windows.Forms.Button();
            this.btnSeparateThread = new System.Windows.Forms.Button();
            this.btnMultipleThreads = new System.Windows.Forms.Button();
            this.txtMainThread = new System.Windows.Forms.TextBox();
            this.txtSeparateThread = new System.Windows.Forms.TextBox();
            this.txtMultipleThreads = new System.Windows.Forms.TextBox();
            this.prgMainThread = new System.Windows.Forms.ProgressBar();
            this.prgSeparateThread = new System.Windows.Forms.ProgressBar();
            this.prgMultipleThreads = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnMainThread
            // 
            this.btnMainThread.Location = new System.Drawing.Point(12, 12);
            this.btnMainThread.Name = "btnMainThread";
            this.btnMainThread.Size = new System.Drawing.Size(282, 63);
            this.btnMainThread.TabIndex = 0;
            this.btnMainThread.Text = "Run on Main Thread\r\n( locks everything.. boo 👎 )";
            this.btnMainThread.UseVisualStyleBackColor = true;
            this.btnMainThread.Click += new System.EventHandler(this.btnMainThread_Click);
            // 
            // btnSeparateThread
            // 
            this.btnSeparateThread.Location = new System.Drawing.Point(311, 12);
            this.btnSeparateThread.Name = "btnSeparateThread";
            this.btnSeparateThread.Size = new System.Drawing.Size(282, 63);
            this.btnSeparateThread.TabIndex = 1;
            this.btnSeparateThread.Text = "Run on Separate Thread\r\n( ui is still responsive! 👍 )\r\n";
            this.btnSeparateThread.UseVisualStyleBackColor = true;
            this.btnSeparateThread.Click += new System.EventHandler(this.btnSeparateThread_Click);
            // 
            // btnMultipleThreads
            // 
            this.btnMultipleThreads.Location = new System.Drawing.Point(610, 12);
            this.btnMultipleThreads.Name = "btnMultipleThreads";
            this.btnMultipleThreads.Size = new System.Drawing.Size(282, 62);
            this.btnMultipleThreads.TabIndex = 2;
            this.btnMultipleThreads.Text = "Run on Multiple Threads\r\n( so much fastness! 🏃‍♂️💨 )";
            this.btnMultipleThreads.UseVisualStyleBackColor = true;
            this.btnMultipleThreads.Click += new System.EventHandler(this.btnMultipleThreads_Click);
            // 
            // txtMainThread
            // 
            this.txtMainThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMainThread.Location = new System.Drawing.Point(12, 111);
            this.txtMainThread.Multiline = true;
            this.txtMainThread.Name = "txtMainThread";
            this.txtMainThread.ReadOnly = true;
            this.txtMainThread.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMainThread.Size = new System.Drawing.Size(282, 233);
            this.txtMainThread.TabIndex = 3;
            // 
            // txtSeparateThread
            // 
            this.txtSeparateThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSeparateThread.Location = new System.Drawing.Point(311, 111);
            this.txtSeparateThread.Multiline = true;
            this.txtSeparateThread.Name = "txtSeparateThread";
            this.txtSeparateThread.ReadOnly = true;
            this.txtSeparateThread.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSeparateThread.Size = new System.Drawing.Size(282, 233);
            this.txtSeparateThread.TabIndex = 4;
            // 
            // txtMultipleThreads
            // 
            this.txtMultipleThreads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMultipleThreads.Location = new System.Drawing.Point(610, 111);
            this.txtMultipleThreads.Multiline = true;
            this.txtMultipleThreads.Name = "txtMultipleThreads";
            this.txtMultipleThreads.ReadOnly = true;
            this.txtMultipleThreads.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMultipleThreads.Size = new System.Drawing.Size(282, 233);
            this.txtMultipleThreads.TabIndex = 5;
            // 
            // prgMainThread
            // 
            this.prgMainThread.Location = new System.Drawing.Point(12, 82);
            this.prgMainThread.MarqueeAnimationSpeed = 30;
            this.prgMainThread.Name = "prgMainThread";
            this.prgMainThread.Size = new System.Drawing.Size(282, 23);
            this.prgMainThread.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgMainThread.TabIndex = 6;
            this.prgMainThread.Visible = false;
            // 
            // prgSeparateThread
            // 
            this.prgSeparateThread.Location = new System.Drawing.Point(311, 81);
            this.prgSeparateThread.MarqueeAnimationSpeed = 30;
            this.prgSeparateThread.Name = "prgSeparateThread";
            this.prgSeparateThread.Size = new System.Drawing.Size(282, 23);
            this.prgSeparateThread.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgSeparateThread.TabIndex = 7;
            this.prgSeparateThread.Visible = false;
            // 
            // prgMultipleThreads
            // 
            this.prgMultipleThreads.Location = new System.Drawing.Point(611, 82);
            this.prgMultipleThreads.MarqueeAnimationSpeed = 30;
            this.prgMultipleThreads.Name = "prgMultipleThreads";
            this.prgMultipleThreads.Size = new System.Drawing.Size(282, 23);
            this.prgMultipleThreads.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgMultipleThreads.TabIndex = 8;
            this.prgMultipleThreads.Visible = false;
            // 
            // frmResponsiveModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 358);
            this.Controls.Add(this.prgMultipleThreads);
            this.Controls.Add(this.prgSeparateThread);
            this.Controls.Add(this.prgMainThread);
            this.Controls.Add(this.txtMultipleThreads);
            this.Controls.Add(this.txtSeparateThread);
            this.Controls.Add(this.txtMainThread);
            this.Controls.Add(this.btnMultipleThreads);
            this.Controls.Add(this.btnSeparateThread);
            this.Controls.Add(this.btnMainThread);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(923, 1200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(923, 300);
            this.Name = "frmResponsiveModal";
            this.Text = "Responsive Modal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainThread;
        private System.Windows.Forms.Button btnSeparateThread;
        private System.Windows.Forms.Button btnMultipleThreads;
        private System.Windows.Forms.TextBox txtMainThread;
        private System.Windows.Forms.TextBox txtSeparateThread;
        private System.Windows.Forms.TextBox txtMultipleThreads;
        private System.Windows.Forms.ProgressBar prgMainThread;
        private System.Windows.Forms.ProgressBar prgSeparateThread;
        private System.Windows.Forms.ProgressBar prgMultipleThreads;
    }
}