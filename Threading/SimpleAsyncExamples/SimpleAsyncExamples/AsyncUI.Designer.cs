namespace SimpleAsyncExamples
{
    partial class AsyncUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gboxAsync1 = new GroupBox();
            lblStatusAsync1 = new Label();
            lblAsync1 = new Label();
            btnRunTask1 = new Button();
            gboxAsync2 = new GroupBox();
            lblStatusAsync2 = new Label();
            label1 = new Label();
            lblAsync2 = new Label();
            btnRunTask2 = new Button();
            btnCancelTask3 = new Button();
            gboxAsync3 = new GroupBox();
            lblStatusAsync3 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblAsync3 = new Label();
            btnRunTask3 = new Button();
            gboxAsync4 = new GroupBox();
            lblStatusAsync4 = new Label();
            btnCancelTask4 = new Button();
            label5 = new Label();
            label6 = new Label();
            lblAsync4 = new Label();
            btnRunTask4 = new Button();
            gboxAsync5 = new GroupBox();
            progBarTask5 = new ProgressBar();
            lblStatusAsync5 = new Label();
            btnCancelTask5 = new Button();
            label7 = new Label();
            label8 = new Label();
            lblAsync5 = new Label();
            btnRunTask5 = new Button();
            gboxAsync1.SuspendLayout();
            gboxAsync2.SuspendLayout();
            gboxAsync3.SuspendLayout();
            gboxAsync4.SuspendLayout();
            gboxAsync5.SuspendLayout();
            SuspendLayout();
            // 
            // gboxAsync1
            // 
            gboxAsync1.Controls.Add(lblStatusAsync1);
            gboxAsync1.Controls.Add(lblAsync1);
            gboxAsync1.Controls.Add(btnRunTask1);
            gboxAsync1.Location = new Point(12, 12);
            gboxAsync1.Name = "gboxAsync1";
            gboxAsync1.Size = new Size(281, 166);
            gboxAsync1.TabIndex = 0;
            gboxAsync1.TabStop = false;
            gboxAsync1.Text = "Example 1";
            // 
            // lblStatusAsync1
            // 
            lblStatusAsync1.AutoSize = true;
            lblStatusAsync1.Location = new Point(6, 118);
            lblStatusAsync1.Name = "lblStatusAsync1";
            lblStatusAsync1.Size = new Size(47, 15);
            lblStatusAsync1.TabIndex = 4;
            lblStatusAsync1.Text = "status...";
            // 
            // lblAsync1
            // 
            lblAsync1.AutoSize = true;
            lblAsync1.Dock = DockStyle.Top;
            lblAsync1.Location = new Point(3, 19);
            lblAsync1.Name = "lblAsync1";
            lblAsync1.Padding = new Padding(0, 10, 0, 0);
            lblAsync1.Size = new Size(274, 25);
            lblAsync1.TabIndex = 3;
            lblAsync1.Text = "Call an async method that completes in 5 seconds.";
            // 
            // btnRunTask1
            // 
            btnRunTask1.Location = new Point(22, 59);
            btnRunTask1.Name = "btnRunTask1";
            btnRunTask1.Size = new Size(75, 23);
            btnRunTask1.TabIndex = 2;
            btnRunTask1.Text = "Run Task";
            btnRunTask1.UseVisualStyleBackColor = true;
            btnRunTask1.Click += btnRunTask1_Click;
            // 
            // gboxAsync2
            // 
            gboxAsync2.Controls.Add(lblStatusAsync2);
            gboxAsync2.Controls.Add(label1);
            gboxAsync2.Controls.Add(lblAsync2);
            gboxAsync2.Controls.Add(btnRunTask2);
            gboxAsync2.Location = new Point(326, 12);
            gboxAsync2.Name = "gboxAsync2";
            gboxAsync2.Size = new Size(281, 166);
            gboxAsync2.TabIndex = 1;
            gboxAsync2.TabStop = false;
            gboxAsync2.Text = "Example 2";
            // 
            // lblStatusAsync2
            // 
            lblStatusAsync2.AutoSize = true;
            lblStatusAsync2.Location = new Point(6, 118);
            lblStatusAsync2.Name = "lblStatusAsync2";
            lblStatusAsync2.Size = new Size(47, 15);
            lblStatusAsync2.TabIndex = 5;
            lblStatusAsync2.Text = "status...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 118);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "           ";
            // 
            // lblAsync2
            // 
            lblAsync2.AutoSize = true;
            lblAsync2.Dock = DockStyle.Top;
            lblAsync2.Location = new Point(3, 19);
            lblAsync2.Name = "lblAsync2";
            lblAsync2.Padding = new Padding(0, 10, 0, 0);
            lblAsync2.Size = new Size(256, 40);
            lblAsync2.TabIndex = 3;
            lblAsync2.Text = "Call an async method that would complete in 5\r\nseconds, but it's cancelled after 3 seconds.";
            // 
            // btnRunTask2
            // 
            btnRunTask2.Location = new Point(23, 73);
            btnRunTask2.Name = "btnRunTask2";
            btnRunTask2.Size = new Size(75, 23);
            btnRunTask2.TabIndex = 2;
            btnRunTask2.Text = "Run Task";
            btnRunTask2.UseVisualStyleBackColor = true;
            btnRunTask2.Click += btnRunTask2_Click;
            // 
            // btnCancelTask3
            // 
            btnCancelTask3.Enabled = false;
            btnCancelTask3.Location = new Point(122, 73);
            btnCancelTask3.Name = "btnCancelTask3";
            btnCancelTask3.Size = new Size(90, 23);
            btnCancelTask3.TabIndex = 6;
            btnCancelTask3.Text = "Cancel Task";
            btnCancelTask3.UseVisualStyleBackColor = true;
            btnCancelTask3.Click += btnCancelTask3_Click;
            // 
            // gboxAsync3
            // 
            gboxAsync3.Controls.Add(lblStatusAsync3);
            gboxAsync3.Controls.Add(btnCancelTask3);
            gboxAsync3.Controls.Add(label2);
            gboxAsync3.Controls.Add(label3);
            gboxAsync3.Controls.Add(lblAsync3);
            gboxAsync3.Controls.Add(btnRunTask3);
            gboxAsync3.Location = new Point(640, 12);
            gboxAsync3.Name = "gboxAsync3";
            gboxAsync3.Size = new Size(281, 166);
            gboxAsync3.TabIndex = 7;
            gboxAsync3.TabStop = false;
            gboxAsync3.Text = "Example 3";
            // 
            // lblStatusAsync3
            // 
            lblStatusAsync3.AutoSize = true;
            lblStatusAsync3.Location = new Point(6, 118);
            lblStatusAsync3.Name = "lblStatusAsync3";
            lblStatusAsync3.Size = new Size(47, 15);
            lblStatusAsync3.TabIndex = 7;
            lblStatusAsync3.Text = "status...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 118);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "           ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 118);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "           ";
            // 
            // lblAsync3
            // 
            lblAsync3.AutoSize = true;
            lblAsync3.Dock = DockStyle.Top;
            lblAsync3.Location = new Point(3, 19);
            lblAsync3.Name = "lblAsync3";
            lblAsync3.Padding = new Padding(0, 10, 0, 0);
            lblAsync3.Size = new Size(250, 40);
            lblAsync3.TabIndex = 3;
            lblAsync3.Text = "Call an async method that runs for 10 seconds\r\nbut is cancellable before that.";
            // 
            // btnRunTask3
            // 
            btnRunTask3.Location = new Point(23, 73);
            btnRunTask3.Name = "btnRunTask3";
            btnRunTask3.Size = new Size(75, 23);
            btnRunTask3.TabIndex = 2;
            btnRunTask3.Text = "Run Task";
            btnRunTask3.UseVisualStyleBackColor = true;
            btnRunTask3.Click += btnRunTask3_Click;
            // 
            // gboxAsync4
            // 
            gboxAsync4.Controls.Add(lblStatusAsync4);
            gboxAsync4.Controls.Add(btnCancelTask4);
            gboxAsync4.Controls.Add(label5);
            gboxAsync4.Controls.Add(label6);
            gboxAsync4.Controls.Add(lblAsync4);
            gboxAsync4.Controls.Add(btnRunTask4);
            gboxAsync4.Location = new Point(12, 207);
            gboxAsync4.Name = "gboxAsync4";
            gboxAsync4.Size = new Size(281, 166);
            gboxAsync4.TabIndex = 8;
            gboxAsync4.TabStop = false;
            gboxAsync4.Text = "Example 4";
            // 
            // lblStatusAsync4
            // 
            lblStatusAsync4.AutoSize = true;
            lblStatusAsync4.Location = new Point(6, 118);
            lblStatusAsync4.Name = "lblStatusAsync4";
            lblStatusAsync4.Size = new Size(47, 15);
            lblStatusAsync4.TabIndex = 7;
            lblStatusAsync4.Text = "status...";
            // 
            // btnCancelTask4
            // 
            btnCancelTask4.Enabled = false;
            btnCancelTask4.Location = new Point(121, 72);
            btnCancelTask4.Name = "btnCancelTask4";
            btnCancelTask4.Size = new Size(90, 23);
            btnCancelTask4.TabIndex = 6;
            btnCancelTask4.Text = "Cancel Task";
            btnCancelTask4.UseVisualStyleBackColor = true;
            btnCancelTask4.Click += btnCancelTask4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 118);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 5;
            label5.Text = "           ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 118);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 4;
            label6.Text = "           ";
            // 
            // lblAsync4
            // 
            lblAsync4.AutoSize = true;
            lblAsync4.Dock = DockStyle.Top;
            lblAsync4.Location = new Point(3, 19);
            lblAsync4.Name = "lblAsync4";
            lblAsync4.Padding = new Padding(0, 10, 0, 0);
            lblAsync4.Size = new Size(233, 40);
            lblAsync4.TabIndex = 3;
            lblAsync4.Text = "Call an async method that runs indefinitely\r\nuntil cancelled.";
            // 
            // btnRunTask4
            // 
            btnRunTask4.Location = new Point(22, 72);
            btnRunTask4.Name = "btnRunTask4";
            btnRunTask4.Size = new Size(75, 23);
            btnRunTask4.TabIndex = 2;
            btnRunTask4.Text = "Run Task";
            btnRunTask4.UseVisualStyleBackColor = true;
            btnRunTask4.Click += btnRunTask4_Click;
            // 
            // gboxAsync5
            // 
            gboxAsync5.Controls.Add(progBarTask5);
            gboxAsync5.Controls.Add(lblStatusAsync5);
            gboxAsync5.Controls.Add(btnCancelTask5);
            gboxAsync5.Controls.Add(label7);
            gboxAsync5.Controls.Add(label8);
            gboxAsync5.Controls.Add(lblAsync5);
            gboxAsync5.Controls.Add(btnRunTask5);
            gboxAsync5.Location = new Point(329, 207);
            gboxAsync5.Name = "gboxAsync5";
            gboxAsync5.Size = new Size(281, 166);
            gboxAsync5.TabIndex = 9;
            gboxAsync5.TabStop = false;
            gboxAsync5.Text = "Example 5";
            // 
            // progBarTask5
            // 
            progBarTask5.Location = new Point(8, 141);
            progBarTask5.Name = "progBarTask5";
            progBarTask5.Size = new Size(267, 23);
            progBarTask5.TabIndex = 8;
            // 
            // lblStatusAsync5
            // 
            lblStatusAsync5.AutoSize = true;
            lblStatusAsync5.Location = new Point(6, 118);
            lblStatusAsync5.Name = "lblStatusAsync5";
            lblStatusAsync5.Size = new Size(47, 15);
            lblStatusAsync5.TabIndex = 7;
            lblStatusAsync5.Text = "status...";
            // 
            // btnCancelTask5
            // 
            btnCancelTask5.Enabled = false;
            btnCancelTask5.Location = new Point(121, 72);
            btnCancelTask5.Name = "btnCancelTask5";
            btnCancelTask5.Size = new Size(90, 23);
            btnCancelTask5.TabIndex = 6;
            btnCancelTask5.Text = "Cancel Task";
            btnCancelTask5.UseVisualStyleBackColor = true;
            btnCancelTask5.Click += btnCancelTask5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 118);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 5;
            label7.Text = "           ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 118);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 4;
            label8.Text = "           ";
            // 
            // lblAsync5
            // 
            lblAsync5.AutoSize = true;
            lblAsync5.Dock = DockStyle.Top;
            lblAsync5.Location = new Point(3, 19);
            lblAsync5.Name = "lblAsync5";
            lblAsync5.Padding = new Padding(0, 10, 0, 0);
            lblAsync5.Size = new Size(214, 40);
            lblAsync5.TabIndex = 3;
            lblAsync5.Text = "Call an async method that runs 10 secs,\r\nis cancellable, and reports progress.";
            // 
            // btnRunTask5
            // 
            btnRunTask5.Location = new Point(22, 72);
            btnRunTask5.Name = "btnRunTask5";
            btnRunTask5.Size = new Size(75, 23);
            btnRunTask5.TabIndex = 2;
            btnRunTask5.Text = "Run Task";
            btnRunTask5.UseVisualStyleBackColor = true;
            btnRunTask5.Click += btnRunTask5_Click;
            // 
            // AsyncUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 387);
            Controls.Add(gboxAsync5);
            Controls.Add(gboxAsync4);
            Controls.Add(gboxAsync3);
            Controls.Add(gboxAsync2);
            Controls.Add(gboxAsync1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AsyncUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Async Examples";
            gboxAsync1.ResumeLayout(false);
            gboxAsync1.PerformLayout();
            gboxAsync2.ResumeLayout(false);
            gboxAsync2.PerformLayout();
            gboxAsync3.ResumeLayout(false);
            gboxAsync3.PerformLayout();
            gboxAsync4.ResumeLayout(false);
            gboxAsync4.PerformLayout();
            gboxAsync5.ResumeLayout(false);
            gboxAsync5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxAsync1;
        private Label lblAsync1;
        private Button btnRunTask1;
        private Label lblStatusAsync1;
        private GroupBox gboxAsync2;
        private Label label1;
        private Label lblAsync2;
        private Button btnRunTask2;
        private Label lblStatusAsync2;
        private Button btnCancelTask3;
        private GroupBox gboxAsync3;
        private Label label2;
        private Label label3;
        private Label lblAsync3;
        private Button btnRunTask3;
        private Label lblStatusAsync3;
        private GroupBox gboxAsync4;
        private Label lblStatusAsync4;
        private Button btnCancelTask4;
        private Label label5;
        private Label label6;
        private Label lblAsync4;
        private Button btnRunTask4;
        private GroupBox gboxAsync5;
        private Label lblStatusAsync5;
        private Button btnCancelTask5;
        private Label label7;
        private Label label8;
        private Label lblAsync5;
        private Button btnRunTask5;
        private ProgressBar progBarTask5;
    }
}
