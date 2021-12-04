namespace AsyncAwait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponsiveModal));
            this.btnMainThread = new System.Windows.Forms.Button();
            this.btnSeparateThread = new System.Windows.Forms.Button();
            this.btnMultipleThreads = new System.Windows.Forms.Button();
            this.txtMainThread = new System.Windows.Forms.TextBox();
            this.txtSeparateThread = new System.Windows.Forms.TextBox();
            this.txtMultipleThreads = new System.Windows.Forms.TextBox();
            this.prgMainThread = new System.Windows.Forms.ProgressBar();
            this.prgSeparateThread = new System.Windows.Forms.ProgressBar();
            this.prgMultipleThreads = new System.Windows.Forms.ProgressBar();
            this.prgMultipleThreadsHeavy = new System.Windows.Forms.ProgressBar();
            this.txtMultipleThreadsHeavy = new System.Windows.Forms.TextBox();
            this.btnMultipleThreadsHeavy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainThread
            // 
            this.btnMainThread.Location = new System.Drawing.Point(9, 10);
            this.btnMainThread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainThread.Name = "btnMainThread";
            this.btnMainThread.Size = new System.Drawing.Size(212, 51);
            this.btnMainThread.TabIndex = 0;
            this.btnMainThread.Text = "Run on Main Thread\r\n( locks everything.. boo 👎 )";
            this.btnMainThread.UseVisualStyleBackColor = true;
            this.btnMainThread.Click += new System.EventHandler(this.btnMainThread_Click);
            // 
            // btnSeparateThread
            // 
            this.btnSeparateThread.Location = new System.Drawing.Point(233, 10);
            this.btnSeparateThread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeparateThread.Name = "btnSeparateThread";
            this.btnSeparateThread.Size = new System.Drawing.Size(212, 51);
            this.btnSeparateThread.TabIndex = 1;
            this.btnSeparateThread.Text = "Run on Separate Thread\r\n( ui is still responsive! 👍 )\r\n";
            this.btnSeparateThread.UseVisualStyleBackColor = true;
            this.btnSeparateThread.Click += new System.EventHandler(this.btnSeparateThread_Click);
            // 
            // btnMultipleThreads
            // 
            this.btnMultipleThreads.Location = new System.Drawing.Point(458, 10);
            this.btnMultipleThreads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMultipleThreads.Name = "btnMultipleThreads";
            this.btnMultipleThreads.Size = new System.Drawing.Size(212, 50);
            this.btnMultipleThreads.TabIndex = 2;
            this.btnMultipleThreads.Text = "Run on Multiple Threads (easy win)\r\n( so much fastness! 🏃‍♂️💨 )";
            this.btnMultipleThreads.UseVisualStyleBackColor = true;
            this.btnMultipleThreads.Click += new System.EventHandler(this.btnMultipleThreads_Click);
            // 
            // txtMainThread
            // 
            this.txtMainThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMainThread.Location = new System.Drawing.Point(9, 90);
            this.txtMainThread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMainThread.Multiline = true;
            this.txtMainThread.Name = "txtMainThread";
            this.txtMainThread.ReadOnly = true;
            this.txtMainThread.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMainThread.Size = new System.Drawing.Size(212, 158);
            this.txtMainThread.TabIndex = 3;
            // 
            // txtSeparateThread
            // 
            this.txtSeparateThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSeparateThread.Location = new System.Drawing.Point(233, 90);
            this.txtSeparateThread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeparateThread.Multiline = true;
            this.txtSeparateThread.Name = "txtSeparateThread";
            this.txtSeparateThread.ReadOnly = true;
            this.txtSeparateThread.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSeparateThread.Size = new System.Drawing.Size(212, 158);
            this.txtSeparateThread.TabIndex = 4;
            // 
            // txtMultipleThreads
            // 
            this.txtMultipleThreads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMultipleThreads.Location = new System.Drawing.Point(458, 90);
            this.txtMultipleThreads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMultipleThreads.Multiline = true;
            this.txtMultipleThreads.Name = "txtMultipleThreads";
            this.txtMultipleThreads.ReadOnly = true;
            this.txtMultipleThreads.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMultipleThreads.Size = new System.Drawing.Size(212, 158);
            this.txtMultipleThreads.TabIndex = 5;
            // 
            // prgMainThread
            // 
            this.prgMainThread.Location = new System.Drawing.Point(9, 67);
            this.prgMainThread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prgMainThread.MarqueeAnimationSpeed = 30;
            this.prgMainThread.Name = "prgMainThread";
            this.prgMainThread.Size = new System.Drawing.Size(212, 19);
            this.prgMainThread.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgMainThread.TabIndex = 6;
            this.prgMainThread.Visible = false;
            // 
            // prgSeparateThread
            // 
            this.prgSeparateThread.Location = new System.Drawing.Point(233, 66);
            this.prgSeparateThread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prgSeparateThread.MarqueeAnimationSpeed = 30;
            this.prgSeparateThread.Name = "prgSeparateThread";
            this.prgSeparateThread.Size = new System.Drawing.Size(212, 19);
            this.prgSeparateThread.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgSeparateThread.TabIndex = 7;
            this.prgSeparateThread.Visible = false;
            // 
            // prgMultipleThreads
            // 
            this.prgMultipleThreads.Location = new System.Drawing.Point(458, 67);
            this.prgMultipleThreads.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prgMultipleThreads.MarqueeAnimationSpeed = 30;
            this.prgMultipleThreads.Name = "prgMultipleThreads";
            this.prgMultipleThreads.Size = new System.Drawing.Size(212, 19);
            this.prgMultipleThreads.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgMultipleThreads.TabIndex = 8;
            this.prgMultipleThreads.Visible = false;
            // 
            // prgMultipleThreadsHeavy
            // 
            this.prgMultipleThreadsHeavy.Location = new System.Drawing.Point(683, 68);
            this.prgMultipleThreadsHeavy.Margin = new System.Windows.Forms.Padding(2);
            this.prgMultipleThreadsHeavy.MarqueeAnimationSpeed = 30;
            this.prgMultipleThreadsHeavy.Name = "prgMultipleThreadsHeavy";
            this.prgMultipleThreadsHeavy.Size = new System.Drawing.Size(212, 19);
            this.prgMultipleThreadsHeavy.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgMultipleThreadsHeavy.TabIndex = 11;
            this.prgMultipleThreadsHeavy.Visible = false;
            // 
            // txtMultipleThreadsHeavy
            // 
            this.txtMultipleThreadsHeavy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMultipleThreadsHeavy.Location = new System.Drawing.Point(683, 91);
            this.txtMultipleThreadsHeavy.Margin = new System.Windows.Forms.Padding(2);
            this.txtMultipleThreadsHeavy.Multiline = true;
            this.txtMultipleThreadsHeavy.Name = "txtMultipleThreadsHeavy";
            this.txtMultipleThreadsHeavy.ReadOnly = true;
            this.txtMultipleThreadsHeavy.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMultipleThreadsHeavy.Size = new System.Drawing.Size(212, 158);
            this.txtMultipleThreadsHeavy.TabIndex = 10;
            // 
            // btnMultipleThreadsHeavy
            // 
            this.btnMultipleThreadsHeavy.Location = new System.Drawing.Point(683, 11);
            this.btnMultipleThreadsHeavy.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultipleThreadsHeavy.Name = "btnMultipleThreadsHeavy";
            this.btnMultipleThreadsHeavy.Size = new System.Drawing.Size(212, 50);
            this.btnMultipleThreadsHeavy.TabIndex = 9;
            this.btnMultipleThreadsHeavy.Text = "Run on Multiple Threads (heavy refactor)\r\n( even more fastness! 🏃‍♂️💨 💨 )";
            this.btnMultipleThreadsHeavy.UseVisualStyleBackColor = true;
            this.btnMultipleThreadsHeavy.Click += new System.EventHandler(this.btnMultipleThreadsHeavy_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(6, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 84);
            this.label1.TabIndex = 12;
            this.label1.Text = "Running everything on the main thread locks up the UI. Notice how nothing else is" +
    " responsive until it\'s finished.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(230, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 84);
            this.label2.TabIndex = 13;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(455, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 84);
            this.label3.TabIndex = 14;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(680, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 84);
            this.label4.TabIndex = 15;
            this.label4.Text = "Finally, with some heavy refactoring (the BreakfastHeavilyDigested class), where " +
    "nearly everything has been changed to async, you get the best results.";
            // 
            // frmResponsiveModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 342);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgMultipleThreadsHeavy);
            this.Controls.Add(this.txtMultipleThreadsHeavy);
            this.Controls.Add(this.btnMultipleThreadsHeavy);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 300);
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
        private System.Windows.Forms.ProgressBar prgMultipleThreadsHeavy;
        private System.Windows.Forms.TextBox txtMultipleThreadsHeavy;
        private System.Windows.Forms.Button btnMultipleThreadsHeavy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}