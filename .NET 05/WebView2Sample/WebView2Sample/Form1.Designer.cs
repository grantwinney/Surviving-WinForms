namespace WebView2Sample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1 = new ToolStrip();
            btnGoBack = new ToolStripButton();
            btnGoFwd = new ToolStripButton();
            btnReload = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNavMicrosoft = new ToolStripButton();
            btnNavGoogle = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnHtmlInlineCssJs = new ToolStripButton();
            btnHtmlInjectCssJs = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnSendMsgFromHtmlToForm = new ToolStripButton();
            btnSendMsgFromFormToHtml = new ToolStripButton();
            txtMsgToSendToHtml = new ToolStripTextBox();
            toolStripSeparator5 = new ToolStripSeparator();
            btnExecuteJS = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            lblNavStatus = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblSourceChanged = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(0, 28);
            webView2.Name = "webView2";
            webView2.Size = new Size(1092, 490);
            webView2.TabIndex = 0;
            webView2.ZoomFactor = 1D;
            webView2.NavigationStarting += webView2_NavigationStarting;
            webView2.NavigationCompleted += webView2_NavigationCompleted;
            webView2.SourceChanged += webView2_SourceChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGoBack, btnGoFwd, btnReload, toolStripSeparator1, btnNavMicrosoft, btnNavGoogle, toolStripSeparator2, btnHtmlInlineCssJs, btnHtmlInjectCssJs, toolStripSeparator3, btnExecuteJS, toolStripSeparator5, btnSendMsgFromHtmlToForm, btnSendMsgFromFormToHtml, txtMsgToSendToHtml });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1092, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGoBack
            // 
            btnGoBack.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnGoBack.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnGoBack.Image = (Image)resources.GetObject("btnGoBack.Image");
            btnGoBack.ImageTransparentColor = Color.Magenta;
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(23, 22);
            btnGoBack.Text = "↩";
            btnGoBack.ToolTipText = "Go Back";
            // 
            // btnGoFwd
            // 
            btnGoFwd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnGoFwd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnGoFwd.Image = (Image)resources.GetObject("btnGoFwd.Image");
            btnGoFwd.ImageTransparentColor = Color.Magenta;
            btnGoFwd.Name = "btnGoFwd";
            btnGoFwd.Size = new Size(23, 22);
            btnGoFwd.Text = "↪";
            btnGoFwd.ToolTipText = "Go Forward";
            // 
            // btnReload
            // 
            btnReload.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.ImageTransparentColor = Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(23, 22);
            btnReload.Text = "⟳";
            btnReload.ToolTipText = "Reload Page";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnNavMicrosoft
            // 
            btnNavMicrosoft.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNavMicrosoft.Image = (Image)resources.GetObject("btnNavMicrosoft.Image");
            btnNavMicrosoft.ImageTransparentColor = Color.Magenta;
            btnNavMicrosoft.Name = "btnNavMicrosoft";
            btnNavMicrosoft.Size = new Size(87, 22);
            btnNavMicrosoft.Text = "Visit Microsoft";
            btnNavMicrosoft.ToolTipText = "Navigate to Microsoft";
            btnNavMicrosoft.Click += btnNavMicrosoft_Click;
            // 
            // btnNavGoogle
            // 
            btnNavGoogle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNavGoogle.Image = (Image)resources.GetObject("btnNavGoogle.Image");
            btnNavGoogle.ImageTransparentColor = Color.Magenta;
            btnNavGoogle.Name = "btnNavGoogle";
            btnNavGoogle.Size = new Size(74, 22);
            btnNavGoogle.Text = "Visit Google";
            btnNavGoogle.ToolTipText = "Navigate to Google";
            btnNavGoogle.Click += btnNavGoogle_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnHtmlInlineCssJs
            // 
            btnHtmlInlineCssJs.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnHtmlInlineCssJs.ImageTransparentColor = Color.Magenta;
            btnHtmlInlineCssJs.Name = "btnHtmlInlineCssJs";
            btnHtmlInlineCssJs.Size = new Size(151, 22);
            btnHtmlInlineCssJs.Text = "Load HTML (inline CSS/JS)";
            btnHtmlInlineCssJs.ToolTipText = "Load a string with inline HTML/CSS/JS";
            btnHtmlInlineCssJs.Click += btnHtmlInlineCssJs_Click;
            // 
            // btnHtmlInjectCssJs
            // 
            btnHtmlInjectCssJs.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnHtmlInjectCssJs.ImageTransparentColor = Color.Magenta;
            btnHtmlInjectCssJs.Name = "btnHtmlInjectCssJs";
            btnHtmlInjectCssJs.Size = new Size(151, 22);
            btnHtmlInjectCssJs.Text = "Load HTML (inject CSS/JS)";
            btnHtmlInjectCssJs.ToolTipText = "Load a string with HTML, then inject CSS/JS after page loads";
            btnHtmlInjectCssJs.Click += btnHtmlInjectCssJs_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnSendMsgFromHtmlToForm
            // 
            btnSendMsgFromHtmlToForm.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSendMsgFromHtmlToForm.Image = (Image)resources.GetObject("btnSendMsgFromHtmlToForm.Image");
            btnSendMsgFromHtmlToForm.ImageTransparentColor = Color.Magenta;
            btnSendMsgFromHtmlToForm.Name = "btnSendMsgFromHtmlToForm";
            btnSendMsgFromHtmlToForm.Size = new Size(131, 22);
            btnSendMsgFromHtmlToForm.Text = "Send Message to Form";
            btnSendMsgFromHtmlToForm.ToolTipText = "Send a message from the HTML page to the WinForms Form";
            btnSendMsgFromHtmlToForm.Click += btnSendMsgFromHtmlToForm_Click;
            // 
            // btnSendMsgFromFormToHtml
            // 
            btnSendMsgFromFormToHtml.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSendMsgFromFormToHtml.Image = (Image)resources.GetObject("btnSendMsgFromFormToHtml.Image");
            btnSendMsgFromFormToHtml.ImageTransparentColor = Color.Magenta;
            btnSendMsgFromFormToHtml.Name = "btnSendMsgFromFormToHtml";
            btnSendMsgFromFormToHtml.Size = new Size(157, 22);
            btnSendMsgFromFormToHtml.Text = "Send Message to HTML -->";
            btnSendMsgFromFormToHtml.ToolTipText = "Send a message from a WinForms TextBox to the HTML page";
            btnSendMsgFromFormToHtml.Click += btnSendMsgFromFormToHtml_Click;
            // 
            // txtMsgToSendToHtml
            // 
            txtMsgToSendToHtml.Name = "txtMsgToSendToHtml";
            txtMsgToSendToHtml.Size = new Size(100, 25);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // btnExecuteJS
            // 
            btnExecuteJS.Name = "btnExecuteJS";
            btnExecuteJS.Size = new Size(80, 22);
            btnExecuteJS.Text = "Execute Script";
            btnExecuteJS.ToolTipText = "Execute a line of JS on whatever page is currently loaded";
            btnExecuteJS.Click += btnExecuteJS_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblNavStatus, toolStripStatusLabel1, lblSourceChanged });
            statusStrip1.Location = new Point(0, 521);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1092, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblNavStatus
            // 
            lblNavStatus.Name = "lblNavStatus";
            lblNavStatus.Size = new Size(73, 17);
            lblNavStatus.Text = "lblNavStatus";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(900, 17);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblSourceChanged
            // 
            lblSourceChanged.Name = "lblSourceChanged";
            lblSourceChanged.Size = new Size(104, 17);
            lblSourceChanged.Text = "lblSourceChanged";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 543);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(webView2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNavMicrosoft;
        private ToolStripButton btnNavGoogle;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnHtmlInlineCssJs;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblNavStatus;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnHtmlInjectCssJs;
        private ToolStripStatusLabel lblSourceChanged;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripLabel btnExecuteJS;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnSendMsgFromFormToHtml;
        private ToolStripTextBox txtMsgToSendToHtml;
        private ToolStripButton btnGoBack;
        private ToolStripButton btnGoFwd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnSendMsgFromHtmlToForm;
        private ToolStripButton btnReload;
    }
}
