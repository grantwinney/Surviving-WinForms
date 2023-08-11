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
            this.lblThread1 = new System.Windows.Forms.Label();
            this.lblThread2 = new System.Windows.Forms.Label();
            this.lblThread3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExample4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReturnValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(3, 3);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(121, 41);
            this.btnExample1.TabIndex = 0;
            this.btnExample1.Text = "Example 1\r\nasync calling async";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // btnExample2
            // 
            this.btnExample2.Location = new System.Drawing.Point(130, 3);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(121, 52);
            this.btnExample2.TabIndex = 1;
            this.btnExample2.Text = "Example 2\r\nsync calling async\r\nno waiting";
            this.btnExample2.UseVisualStyleBackColor = true;
            this.btnExample2.Click += new System.EventHandler(this.btnExample2_Click);
            // 
            // btnExample3
            // 
            this.btnExample3.Location = new System.Drawing.Point(257, 3);
            this.btnExample3.Name = "btnExample3";
            this.btnExample3.Size = new System.Drawing.Size(121, 52);
            this.btnExample3.TabIndex = 2;
            this.btnExample3.Text = "Example 3\r\nsync calling async\r\ni\'ll just wait thanks";
            this.btnExample3.UseVisualStyleBackColor = true;
            this.btnExample3.Click += new System.EventHandler(this.btnExample3_Click);
            // 
            // lblThread1
            // 
            this.lblThread1.AutoSize = true;
            this.lblThread1.Location = new System.Drawing.Point(269, 156);
            this.lblThread1.Name = "lblThread1";
            this.lblThread1.Size = new System.Drawing.Size(35, 13);
            this.lblThread1.TabIndex = 3;
            this.lblThread1.Text = "label1";
            // 
            // lblThread2
            // 
            this.lblThread2.AutoSize = true;
            this.lblThread2.Location = new System.Drawing.Point(269, 188);
            this.lblThread2.Name = "lblThread2";
            this.lblThread2.Size = new System.Drawing.Size(35, 13);
            this.lblThread2.TabIndex = 4;
            this.lblThread2.Text = "label2";
            // 
            // lblThread3
            // 
            this.lblThread3.AutoSize = true;
            this.lblThread3.Location = new System.Drawing.Point(269, 220);
            this.lblThread3.Name = "lblThread3";
            this.lblThread3.Size = new System.Drawing.Size(35, 13);
            this.lblThread3.TabIndex = 5;
            this.lblThread3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "WhyNotOneMoreAsyncMethod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AndYetAnotherAsyncMethod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CallSomeOtherAsyncMethod:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnExample1);
            this.pnlButtons.Controls.Add(this.btnExample2);
            this.pnlButtons.Controls.Add(this.btnExample3);
            this.pnlButtons.Controls.Add(this.btnExample4);
            this.pnlButtons.Location = new System.Drawing.Point(12, 12);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(527, 60);
            this.pnlButtons.TabIndex = 10;
            // 
            // btnExample4
            // 
            this.btnExample4.Location = new System.Drawing.Point(384, 3);
            this.btnExample4.Name = "btnExample4";
            this.btnExample4.Size = new System.Drawing.Size(137, 52);
            this.btnExample4.TabIndex = 3;
            this.btnExample4.Text = "Example 4\r\nsync calling async\r\nwaiting for return value";
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
            this.lblReturnValue.AutoSize = true;
            this.lblReturnValue.Location = new System.Drawing.Point(419, 143);
            this.lblReturnValue.Name = "lblReturnValue";
            this.lblReturnValue.Size = new System.Drawing.Size(76, 13);
            this.lblReturnValue.TabIndex = 12;
            this.lblReturnValue.Tag = "";
            this.lblReturnValue.Text = "lblReturnValue";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(143, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 46);
            this.label5.TabIndex = 13;
            this.label5.Text = "No wait for task to finish. The buttons are immediately re-enabled.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(308, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "↑ These wait for tasks to finish, ↑\r\n which locks the UI for a bit.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "Button event method is async. Everything nice and responsive.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 257);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblReturnValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThread3);
            this.Controls.Add(this.lblThread2);
            this.Controls.Add(this.lblThread1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.Button btnExample2;
        private System.Windows.Forms.Button btnExample3;
        private System.Windows.Forms.Label lblThread1;
        private System.Windows.Forms.Label lblThread2;
        private System.Windows.Forms.Label lblThread3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnExample4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReturnValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

