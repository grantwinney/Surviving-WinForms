
namespace NLogUtility
{
    partial class NLogUtility
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
            this.btnLogException = new System.Windows.Forms.Button();
            this.btnLogInfo = new System.Windows.Forms.Button();
            this.chkIncludeStackTrace = new System.Windows.Forms.CheckBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtFileContents = new System.Windows.Forms.TextBox();
            this.btnLogTrace = new System.Windows.Forms.Button();
            this.logWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.logWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogException
            // 
            this.btnLogException.Location = new System.Drawing.Point(12, 27);
            this.btnLogException.Name = "btnLogException";
            this.btnLogException.Size = new System.Drawing.Size(126, 51);
            this.btnLogException.TabIndex = 0;
            this.btnLogException.Text = "Log Exception (Error)";
            this.btnLogException.UseVisualStyleBackColor = true;
            this.btnLogException.Click += new System.EventHandler(this.btnLogException_Click);
            // 
            // btnLogInfo
            // 
            this.btnLogInfo.Location = new System.Drawing.Point(12, 261);
            this.btnLogInfo.Name = "btnLogInfo";
            this.btnLogInfo.Size = new System.Drawing.Size(126, 50);
            this.btnLogInfo.TabIndex = 1;
            this.btnLogInfo.Text = "Log Message (Informational)";
            this.btnLogInfo.UseVisualStyleBackColor = true;
            this.btnLogInfo.Click += new System.EventHandler(this.btnLogInfo_Click);
            // 
            // chkIncludeStackTrace
            // 
            this.chkIncludeStackTrace.Location = new System.Drawing.Point(160, 266);
            this.chkIncludeStackTrace.Name = "chkIncludeStackTrace";
            this.chkIncludeStackTrace.Size = new System.Drawing.Size(104, 43);
            this.chkIncludeStackTrace.TabIndex = 2;
            this.chkIncludeStackTrace.Text = "Include Stacktrace";
            this.chkIncludeStackTrace.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 145);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(252, 110);
            this.txtMessage.TabIndex = 3;
            // 
            // txtFileContents
            // 
            this.txtFileContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileContents.Location = new System.Drawing.Point(279, 12);
            this.txtFileContents.Multiline = true;
            this.txtFileContents.Name = "txtFileContents";
            this.txtFileContents.ReadOnly = true;
            this.txtFileContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFileContents.Size = new System.Drawing.Size(496, 440);
            this.txtFileContents.TabIndex = 4;
            // 
            // btnLogTrace
            // 
            this.btnLogTrace.Location = new System.Drawing.Point(12, 388);
            this.btnLogTrace.Name = "btnLogTrace";
            this.btnLogTrace.Size = new System.Drawing.Size(126, 50);
            this.btnLogTrace.TabIndex = 5;
            this.btnLogTrace.Text = "Log StackTrace (Trace)";
            this.btnLogTrace.UseVisualStyleBackColor = true;
            this.btnLogTrace.Click += new System.EventHandler(this.btnLogTrace_Click);
            // 
            // logWatcher
            // 
            this.logWatcher.EnableRaisingEvents = true;
            this.logWatcher.Filter = "*.txt";
            this.logWatcher.SynchronizingObject = this;
            // 
            // NLogUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 464);
            this.Controls.Add(this.btnLogTrace);
            this.Controls.Add(this.txtFileContents);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.chkIncludeStackTrace);
            this.Controls.Add(this.btnLogInfo);
            this.Controls.Add(this.btnLogException);
            this.MinimumSize = new System.Drawing.Size(805, 511);
            this.Name = "NLogUtility";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NLogUtility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogException;
        private System.Windows.Forms.Button btnLogInfo;
        private System.Windows.Forms.CheckBox chkIncludeStackTrace;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtFileContents;
        private System.Windows.Forms.Button btnLogTrace;
        private System.IO.FileSystemWatcher logWatcher;
    }
}

