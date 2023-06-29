namespace MultipleNLogTargets
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnLogTrace = new System.Windows.Forms.Button();
            this.btnLogInfo = new System.Windows.Forms.Button();
            this.btnLogCritical = new System.Windows.Forms.Button();
            this.btnLogException = new System.Windows.Forms.Button();
            this.btnLogWarning = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLogDebug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 25);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(327, 98);
            this.txtMessage.TabIndex = 12;
            // 
            // btnLogTrace
            // 
            this.btnLogTrace.BackColor = System.Drawing.Color.White;
            this.btnLogTrace.Location = new System.Drawing.Point(368, 25);
            this.btnLogTrace.Name = "btnLogTrace";
            this.btnLogTrace.Size = new System.Drawing.Size(140, 23);
            this.btnLogTrace.TabIndex = 1;
            this.btnLogTrace.Text = "Log Trace Message";
            this.btnLogTrace.UseVisualStyleBackColor = false;
            this.btnLogTrace.Click += new System.EventHandler(this.btnLogTrace_Click);
            // 
            // btnLogInfo
            // 
            this.btnLogInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogInfo.Location = new System.Drawing.Point(368, 83);
            this.btnLogInfo.Name = "btnLogInfo";
            this.btnLogInfo.Size = new System.Drawing.Size(140, 23);
            this.btnLogInfo.TabIndex = 2;
            this.btnLogInfo.Text = "Log Info Message";
            this.btnLogInfo.UseVisualStyleBackColor = false;
            this.btnLogInfo.Click += new System.EventHandler(this.btnLogInfo_Click);
            // 
            // btnLogCritical
            // 
            this.btnLogCritical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogCritical.ForeColor = System.Drawing.Color.White;
            this.btnLogCritical.Location = new System.Drawing.Point(368, 170);
            this.btnLogCritical.Name = "btnLogCritical";
            this.btnLogCritical.Size = new System.Drawing.Size(140, 23);
            this.btnLogCritical.TabIndex = 3;
            this.btnLogCritical.Text = "Log Critical Message";
            this.btnLogCritical.UseVisualStyleBackColor = false;
            this.btnLogCritical.Click += new System.EventHandler(this.btnLogCritical_Click);
            // 
            // btnLogException
            // 
            this.btnLogException.BackColor = System.Drawing.Color.Red;
            this.btnLogException.ForeColor = System.Drawing.Color.White;
            this.btnLogException.Location = new System.Drawing.Point(368, 141);
            this.btnLogException.Name = "btnLogException";
            this.btnLogException.Size = new System.Drawing.Size(140, 23);
            this.btnLogException.TabIndex = 4;
            this.btnLogException.Text = "Log Exception Message";
            this.btnLogException.UseVisualStyleBackColor = false;
            this.btnLogException.Click += new System.EventHandler(this.btnLogException_Click);
            // 
            // btnLogWarning
            // 
            this.btnLogWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogWarning.ForeColor = System.Drawing.Color.White;
            this.btnLogWarning.Location = new System.Drawing.Point(368, 112);
            this.btnLogWarning.Name = "btnLogWarning";
            this.btnLogWarning.Size = new System.Drawing.Size(140, 23);
            this.btnLogWarning.TabIndex = 5;
            this.btnLogWarning.Text = "Log Warning Message";
            this.btnLogWarning.UseVisualStyleBackColor = false;
            this.btnLogWarning.Click += new System.EventHandler(this.btnLogWarning_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Message:";
            // 
            // btnLogDebug
            // 
            this.btnLogDebug.BackColor = System.Drawing.Color.Ivory;
            this.btnLogDebug.Location = new System.Drawing.Point(368, 54);
            this.btnLogDebug.Name = "btnLogDebug";
            this.btnLogDebug.Size = new System.Drawing.Size(140, 23);
            this.btnLogDebug.TabIndex = 14;
            this.btnLogDebug.Text = "Log Debug Message";
            this.btnLogDebug.UseVisualStyleBackColor = false;
            this.btnLogDebug.Click += new System.EventHandler(this.btnLogDebug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 209);
            this.Controls.Add(this.btnLogDebug);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnLogWarning);
            this.Controls.Add(this.btnLogException);
            this.Controls.Add(this.btnLogCritical);
            this.Controls.Add(this.btnLogInfo);
            this.Controls.Add(this.btnLogTrace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnLogTrace;
        private System.Windows.Forms.Button btnLogInfo;
        private System.Windows.Forms.Button btnLogCritical;
        private System.Windows.Forms.Button btnLogException;
        private System.Windows.Forms.Button btnLogWarning;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLogDebug;
    }
}

