namespace TaskDialogSample
{
    partial class Form1
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
            btnMessageBox = new Button();
            btnTaskDialogConfirmAction = new Button();
            btnTaskDialogShowException = new Button();
            btnTaskDialogAcceptEULA = new Button();
            btnTaskDialogWaitAwhile = new Button();
            SuspendLayout();
            // 
            // btnMessageBox
            // 
            btnMessageBox.Location = new Point(12, 12);
            btnMessageBox.Name = "btnMessageBox";
            btnMessageBox.Size = new Size(117, 64);
            btnMessageBox.TabIndex = 1;
            btnMessageBox.Text = "Confirm Action\r\nvia\r\nMessageBox";
            btnMessageBox.UseVisualStyleBackColor = true;
            btnMessageBox.Click += btnMessageBoxConfirmAction_Click;
            // 
            // btnTaskDialogConfirmAction
            // 
            btnTaskDialogConfirmAction.Location = new Point(135, 12);
            btnTaskDialogConfirmAction.Name = "btnTaskDialogConfirmAction";
            btnTaskDialogConfirmAction.Size = new Size(117, 64);
            btnTaskDialogConfirmAction.TabIndex = 2;
            btnTaskDialogConfirmAction.Text = "Confirm Action\r\nvia\r\nTaskDialog";
            btnTaskDialogConfirmAction.UseVisualStyleBackColor = true;
            btnTaskDialogConfirmAction.Click += btnTaskDialogConfirmAction_Click;
            // 
            // btnTaskDialogShowException
            // 
            btnTaskDialogShowException.Location = new Point(12, 82);
            btnTaskDialogShowException.Name = "btnTaskDialogShowException";
            btnTaskDialogShowException.Size = new Size(117, 64);
            btnTaskDialogShowException.TabIndex = 3;
            btnTaskDialogShowException.Text = "Show Exception\r\nvia\r\nTaskDialog";
            btnTaskDialogShowException.UseVisualStyleBackColor = true;
            btnTaskDialogShowException.Click += btnTaskDialogShowException_Click;
            // 
            // btnTaskDialogAcceptEULA
            // 
            btnTaskDialogAcceptEULA.Location = new Point(135, 82);
            btnTaskDialogAcceptEULA.Name = "btnTaskDialogAcceptEULA";
            btnTaskDialogAcceptEULA.Size = new Size(117, 64);
            btnTaskDialogAcceptEULA.TabIndex = 4;
            btnTaskDialogAcceptEULA.Text = "Accept EULA\r\nvia\r\nTaskDialog";
            btnTaskDialogAcceptEULA.UseVisualStyleBackColor = true;
            btnTaskDialogAcceptEULA.Click += btnTaskDialogAcceptEULA_Click;
            // 
            // btnTaskDialogWaitAwhile
            // 
            btnTaskDialogWaitAwhile.Location = new Point(258, 82);
            btnTaskDialogWaitAwhile.Name = "btnTaskDialogWaitAwhile";
            btnTaskDialogWaitAwhile.Size = new Size(117, 64);
            btnTaskDialogWaitAwhile.TabIndex = 5;
            btnTaskDialogWaitAwhile.Text = "Wait Awhile\r\nvia\r\nTaskDialog";
            btnTaskDialogWaitAwhile.UseVisualStyleBackColor = true;
            btnTaskDialogWaitAwhile.Click += btnTaskDialogWaitAwhile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 347);
            Controls.Add(btnTaskDialogWaitAwhile);
            Controls.Add(btnTaskDialogAcceptEULA);
            Controls.Add(btnTaskDialogShowException);
            Controls.Add(btnTaskDialogConfirmAction);
            Controls.Add(btnMessageBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnMessageBox;
        private Button btnTaskDialogConfirmAction;
        private Button btnTaskDialogShowException;
        private Button btnTaskDialogAcceptEULA;
        private Button btnTaskDialogWaitAwhile;
    }
}
