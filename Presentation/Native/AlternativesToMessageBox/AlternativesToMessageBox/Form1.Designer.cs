namespace AlternativesToMessageBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUseMessageBox = new System.Windows.Forms.Button();
            this.btnUseStatusStrip = new System.Windows.Forms.Button();
            this.btnUseSeparateForm = new System.Windows.Forms.Button();
            this.btnUseFlowLayoutPanel = new System.Windows.Forms.Button();
            this.btnUseNotifyIcon = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanelMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUseMessageBox
            // 
            this.btnUseMessageBox.Location = new System.Drawing.Point(12, 12);
            this.btnUseMessageBox.Name = "btnUseMessageBox";
            this.btnUseMessageBox.Size = new System.Drawing.Size(104, 52);
            this.btnUseMessageBox.TabIndex = 0;
            this.btnUseMessageBox.Text = "Use the standard MessageBox";
            this.btnUseMessageBox.UseVisualStyleBackColor = true;
            this.btnUseMessageBox.Click += new System.EventHandler(this.btnUseMessageBox_Click);
            // 
            // btnUseStatusStrip
            // 
            this.btnUseStatusStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUseStatusStrip.Location = new System.Drawing.Point(12, 311);
            this.btnUseStatusStrip.Name = "btnUseStatusStrip";
            this.btnUseStatusStrip.Size = new System.Drawing.Size(91, 52);
            this.btnUseStatusStrip.TabIndex = 1;
            this.btnUseStatusStrip.Text = "Use a label in a StatusStrip ↓";
            this.btnUseStatusStrip.UseVisualStyleBackColor = true;
            this.btnUseStatusStrip.Click += new System.EventHandler(this.btnUseStatusStrip_Click);
            // 
            // btnUseSeparateForm
            // 
            this.btnUseSeparateForm.Location = new System.Drawing.Point(12, 70);
            this.btnUseSeparateForm.Name = "btnUseSeparateForm";
            this.btnUseSeparateForm.Size = new System.Drawing.Size(104, 52);
            this.btnUseSeparateForm.TabIndex = 2;
            this.btnUseSeparateForm.Text = "Use a separate form for messages";
            this.btnUseSeparateForm.UseVisualStyleBackColor = true;
            this.btnUseSeparateForm.Click += new System.EventHandler(this.btnUseSeparateForm_Click);
            // 
            // btnUseFlowLayoutPanel
            // 
            this.btnUseFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseFlowLayoutPanel.Location = new System.Drawing.Point(296, 12);
            this.btnUseFlowLayoutPanel.Name = "btnUseFlowLayoutPanel";
            this.btnUseFlowLayoutPanel.Size = new System.Drawing.Size(104, 52);
            this.btnUseFlowLayoutPanel.TabIndex = 3;
            this.btnUseFlowLayoutPanel.Text = "Use labels in a → FlowLayoutPanel";
            this.btnUseFlowLayoutPanel.UseVisualStyleBackColor = true;
            this.btnUseFlowLayoutPanel.Click += new System.EventHandler(this.btnUseFlowLayoutPanel_Click);
            // 
            // btnUseNotifyIcon
            // 
            this.btnUseNotifyIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseNotifyIcon.Location = new System.Drawing.Point(450, 151);
            this.btnUseNotifyIcon.Name = "btnUseNotifyIcon";
            this.btnUseNotifyIcon.Size = new System.Drawing.Size(104, 52);
            this.btnUseNotifyIcon.TabIndex = 4;
            this.btnUseNotifyIcon.Text = "Use the Windows notification area →";
            this.btnUseNotifyIcon.UseVisualStyleBackColor = true;
            this.btnUseNotifyIcon.Click += new System.EventHandler(this.btnUseNotifyIcon_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Just so, SO important...";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(158, 17);
            this.toolStripStatusLabelMessage.Text = "toolStripStatusLabelMessage";
            // 
            // flowLayoutPanelMessages
            // 
            this.flowLayoutPanelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMessages.AutoScroll = true;
            this.flowLayoutPanelMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMessages.Location = new System.Drawing.Point(406, 1);
            this.flowLayoutPanelMessages.Name = "flowLayoutPanelMessages";
            this.flowLayoutPanelMessages.Size = new System.Drawing.Size(313, 144);
            this.flowLayoutPanelMessages.TabIndex = 6;
            this.flowLayoutPanelMessages.WrapContents = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.flowLayoutPanelMessages);
            this.Controls.Add(this.btnUseStatusStrip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUseNotifyIcon);
            this.Controls.Add(this.btnUseFlowLayoutPanel);
            this.Controls.Add(this.btnUseSeparateForm);
            this.Controls.Add(this.btnUseMessageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUseMessageBox;
        private System.Windows.Forms.Button btnUseStatusStrip;
        private System.Windows.Forms.Button btnUseSeparateForm;
        private System.Windows.Forms.Button btnUseFlowLayoutPanel;
        private System.Windows.Forms.Button btnUseNotifyIcon;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMessages;
        private System.Windows.Forms.Timer timer1;
    }
}

