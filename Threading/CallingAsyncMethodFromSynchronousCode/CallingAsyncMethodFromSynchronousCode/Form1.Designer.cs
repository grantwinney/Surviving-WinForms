namespace CallingAsyncMethodFromSynchronousCode
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
            this.btnExample1 = new System.Windows.Forms.Button();
            this.btnExample2 = new System.Windows.Forms.Button();
            this.btnExample3 = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExample5 = new System.Windows.Forms.Button();
            this.btnExample4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReturnValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(507, 3);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(120, 52);
            this.btnExample1.TabIndex = 0;
            this.btnExample1.Text = "Example 5\r\nAsync all the things\r\n ";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.btnExample5_Click);
            // 
            // btnExample2
            // 
            this.btnExample2.Location = new System.Drawing.Point(129, 3);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(120, 52);
            this.btnExample2.TabIndex = 1;
            this.btnExample2.Text = "Example 2\r\nSync over Async\r\nNo waiting";
            this.btnExample2.UseVisualStyleBackColor = true;
            this.btnExample2.Click += new System.EventHandler(this.btnExample2_Click);
            // 
            // btnExample3
            // 
            this.btnExample3.Location = new System.Drawing.Point(255, 3);
            this.btnExample3.Name = "btnExample3";
            this.btnExample3.Size = new System.Drawing.Size(120, 52);
            this.btnExample3.TabIndex = 2;
            this.btnExample3.Text = "Example 3\r\nSync over Async\r\nCalls .Wait";
            this.btnExample3.UseVisualStyleBackColor = true;
            this.btnExample3.Click += new System.EventHandler(this.btnExample3_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnExample5);
            this.pnlButtons.Controls.Add(this.btnExample2);
            this.pnlButtons.Controls.Add(this.btnExample3);
            this.pnlButtons.Controls.Add(this.btnExample4);
            this.pnlButtons.Controls.Add(this.btnExample1);
            this.pnlButtons.Location = new System.Drawing.Point(12, 12);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(635, 60);
            this.pnlButtons.TabIndex = 10;
            // 
            // btnExample5
            // 
            this.btnExample5.Location = new System.Drawing.Point(3, 3);
            this.btnExample5.Name = "btnExample5";
            this.btnExample5.Size = new System.Drawing.Size(120, 52);
            this.btnExample5.TabIndex = 4;
            this.btnExample5.Text = "Example 1\r\nSync over Async\r\nDeadlock the app";
            this.btnExample5.UseVisualStyleBackColor = true;
            this.btnExample5.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // btnExample4
            // 
            this.btnExample4.Location = new System.Drawing.Point(381, 3);
            this.btnExample4.Name = "btnExample4";
            this.btnExample4.Size = new System.Drawing.Size(120, 52);
            this.btnExample4.TabIndex = 3;
            this.btnExample4.Text = "Example 4\r\nSync over Async\r\nCalls.Result";
            this.btnExample4.UseVisualStyleBackColor = true;
            this.btnExample4.Click += new System.EventHandler(this.btnExample4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Return value:";
            // 
            // lblReturnValue
            // 
            this.lblReturnValue.Location = new System.Drawing.Point(419, 143);
            this.lblReturnValue.Name = "lblReturnValue";
            this.lblReturnValue.Size = new System.Drawing.Size(220, 52);
            this.lblReturnValue.TabIndex = 12;
            this.lblReturnValue.Tag = "";
            this.lblReturnValue.Text = "lblReturnValue";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(141, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 46);
            this.label5.TabIndex = 13;
            this.label5.Text = "Doesn\'t wait for the Task to finish.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(305, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "↑ Waits for Task to finish, ↑\r\n which locks the UI.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(519, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Async all the way.\r\nUI is responsive.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 195);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(658, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 3;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar1.Value = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(25, 17);
            this.lblStatus.Text = "n/a";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 33);
            this.label8.TabIndex = 17;
            this.label8.Text = "This one deadlocks the application. :(";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 217);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblReturnValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.pnlButtons.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.Button btnExample2;
        private System.Windows.Forms.Button btnExample3;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnExample4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReturnValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnExample5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

