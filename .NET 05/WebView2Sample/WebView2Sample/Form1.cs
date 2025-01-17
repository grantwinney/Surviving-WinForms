using Microsoft.Web.WebView2.Core;

namespace WebView2Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblNavStatus.Text = lblSourceChanged.Text = "";
            btnGoBack.Click += (s, e) => webView2.CoreWebView2.GoBack();
            btnGoFwd.Click += (s, e) => webView2.CoreWebView2.GoForward();
            btnReload.Click += (s, e) => webView2.CoreWebView2.Reload();

            InitializeWebView2();
        }

        async void InitializeWebView2()
        {
            await webView2.EnsureCoreWebView2Async();

            // Handle messages from WinForms to the WebView2
            await webView2.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(
                "window.chrome.webview.addEventListener('message', evt => alert(evt.data));");

            // Handle messages from the WebView2 to WinForms
            webView2.WebMessageReceived += (s, e) =>
                MessageBox.Show(e.TryGetWebMessageAsString());

            // Scripts like this one run on every page load
            // until you call RemoveScriptToExecuteOnDocumentCreated()
            //await webView2.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(
            //    """
            //    document.addEventListener('readystatechange', evt => {
            //        if (document.readyState === 'complete') {
            //            document.head.insertAdjacentHTML('beforeend',
            //                '<style>body,div {background: lightyellow !important}</style>');
            //        }
            //    });
            //    """);
        }

        private void btnNavMicrosoft_Click(object sender, EventArgs e)
        {
            // Load Microsoft
            webView2.CoreWebView2.Navigate("https://microsoft.com");
        }

        private void btnNavGoogle_Click(object sender, EventArgs e)
        {
            // Load Google
            webView2.CoreWebView2.Navigate("https://google.com");
        }

        private void btnHtmlInlineCssJs_Click(object sender, EventArgs e)
        {
            // Load HTML with inline JS/CSS
            webView2.NavigateToString(
                """
                <html>
                    <head>
                        <style>p{color:green; font-weight:bold}</style>
                    </head>
                    <body>
                        <p>Not much to see here.....</p>
                        <button onClick="alert('Unbelievable...')">DON'T PRESS ME</button>
                    </body>
                </html>
                """);
        }

        private async void btnHtmlInjectCssJs_Click(object sender, EventArgs e)
        {
            // Define some JS and CSS to add to the page after it loads
            var scriptID = await webView2.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(
                """
                document.addEventListener('readystatechange', evt => {
                    if (document.readyState === 'complete') {
                        document.getElementById('btn')
                            .addEventListener('click', function() {alert('Just.. why?')});
                        document.head.insertAdjacentHTML('beforeend',
                            '<style>p{color:red; font-style:italic}</style>');
                    }
                });
                """);

            // Load HTML sans JS/CSS
            webView2.NavigateToString(
                """
                <p>Move along.. nothing to see here...</p>
                <button id='btn'>DON'T PRESS ME</button>
                """);

            webView2.CoreWebView2.RemoveScriptToExecuteOnDocumentCreated(scriptID);
        }

        private void btnSendMsgFromHtmlToForm_Click(object sender, EventArgs e)
        {
            // Add a button that, upon clicking, sends a message to WinForms
            webView2.NavigateToString(
                """
                <html>
                    <head>
                        <style>button {color:blue; font-weight:bold}</style>
                    </head>
                    <body>
                        <p>Press the button to send a message to the Form, which will display it in a MessageBox.</p>
                        <input type="text" id="user_msg" placeholder="Type your message here...">
                        <button onclick="window.chrome.webview.postMessage(document.getElementById('user_msg').value);">
                            SEND MESSAGE
                        </button>
                    </body>
                </html>
                """
            );
        }

        private void btnSendMsgFromFormToHtml_Click(object sender, EventArgs e)
        {
            // See the "InitializeWebView2()" method, where we tell the WebView2 control
            // what to do with messages we send to it... display them in an alert box
            webView2.CoreWebView2.PostWebMessageAsString(txtMsgToSendToHtml.Text);
        }

        private void btnExecuteJS_Click(object sender, EventArgs e)
        {
            // Execute a script in the top-level document
            webView2.ExecuteScriptAsync("alert('Hi there, hello.')");
        }

        private void webView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if (e.NavigationKind == CoreWebView2NavigationKind.NewDocument)
                lblNavStatus.Text = $"Loading {e.Uri}";
            else if (e.NavigationKind == CoreWebView2NavigationKind.Reload)
                lblNavStatus.Text = $"Refreshing {e.Uri}";
            else
                lblNavStatus.Text = "";
        }

        private void webView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            lblNavStatus.Text = e.IsSuccess ? "Done!" : "Failed!";
        }

        private void webView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            lblSourceChanged.Text = $"Source changed to: {webView2.Source}";
        }
    }
}
