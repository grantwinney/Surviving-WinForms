using System.Windows.Forms;

namespace MessageBoxForDevs
{
    partial class frmMain
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
            this.btnDivisionByZero = new System.Windows.Forms.Button();
            this.btnOpenMissingFile = new System.Windows.Forms.Button();
            this.btnIndexOutOfRangeException = new System.Windows.Forms.Button();
            this.btnNeverGonnaWork = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDivisionByZero
            // 
            this.btnDivisionByZero.Location = new System.Drawing.Point(27, 24);
            this.btnDivisionByZero.Name = "btnDivisionByZero";
            this.btnDivisionByZero.Size = new System.Drawing.Size(120, 40);
            this.btnDivisionByZero.TabIndex = 0;
            this.btnDivisionByZero.Text = "Divide by zero";
            this.btnDivisionByZero.UseVisualStyleBackColor = true;
            this.btnDivisionByZero.Click += new System.EventHandler(this.btnDivisionByZero_Click);
            // 
            // btnOpenMissingFile
            // 
            this.btnOpenMissingFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenMissingFile.Location = new System.Drawing.Point(42, 73);
            this.btnOpenMissingFile.Name = "btnOpenMissingFile";
            this.btnOpenMissingFile.Size = new System.Drawing.Size(120, 40);
            this.btnOpenMissingFile.TabIndex = 1;
            this.btnOpenMissingFile.Text = "Open missing file";
            this.btnOpenMissingFile.UseVisualStyleBackColor = true;
            this.btnOpenMissingFile.Click += new System.EventHandler(this.btnOpenMissingFile_Click);
            // 
            // btnIndexOutOfRangeException
            // 
            this.btnIndexOutOfRangeException.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIndexOutOfRangeException.Location = new System.Drawing.Point(57, 122);
            this.btnIndexOutOfRangeException.Name = "btnIndexOutOfRangeException";
            this.btnIndexOutOfRangeException.Size = new System.Drawing.Size(120, 40);
            this.btnIndexOutOfRangeException.TabIndex = 2;
            this.btnIndexOutOfRangeException.Text = "Index out of range";
            this.btnIndexOutOfRangeException.UseVisualStyleBackColor = true;
            this.btnIndexOutOfRangeException.Click += new System.EventHandler(this.btnIndexOutOfRangeException_Click);
            // 
            // btnNeverGonnaWork
            // 
            this.btnNeverGonnaWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNeverGonnaWork.Location = new System.Drawing.Point(291, 82);
            this.btnNeverGonnaWork.Name = "btnNeverGonnaWork";
            this.btnNeverGonnaWork.Size = new System.Drawing.Size(123, 63);
            this.btnNeverGonnaWork.TabIndex = 3;
            this.btnNeverGonnaWork.Text = "Enter a number between 41 and 42";
            this.btnNeverGonnaWork.UseVisualStyleBackColor = true;
            this.btnNeverGonnaWork.Click += new System.EventHandler(this.btnNeverGonnaWork_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(291, 53);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(123, 23);
            this.txtInput.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 213);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnNeverGonnaWork);
            this.Controls.Add(this.btnIndexOutOfRangeException);
            this.Controls.Add(this.btnOpenMissingFile);
            this.Controls.Add(this.btnDivisionByZero);
            this.MinimumSize = new System.Drawing.Size(441, 252);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "An Exceptional App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDivisionByZero;
        private Button btnOpenMissingFile;
        private Button btnIndexOutOfRangeException;
        private Button btnNeverGonnaWork;
        private TextBox txtInput;
    }
}