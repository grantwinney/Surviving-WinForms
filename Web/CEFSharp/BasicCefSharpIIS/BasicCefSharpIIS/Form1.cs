using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicCefSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chromiumWebBrowser1.KeyboardHandler = new FancyKeyboardHandler(txtName, dtpGraduation);
            chromiumWebBrowser1.MenuHandler = new ContextMenuHandler();

            chromiumWebBrowser1.LoadingStateChanged += chromiumWebBrowser1_LoadingStateChanged;
            chromiumWebBrowser1.JavascriptMessageReceived += chromiumWebBrowser1_JavascriptMessageReceived;
            
            chromiumWebBrowser1.AddressChanged += (_, evt) =>
            {
                txtAddress.Apply(() => txtAddress.Text = evt.Address);
                pnlControls.Apply(() => pnlControls.Enabled = !evt.Address.EndsWith("about.html"));
            };

            chromiumWebBrowser1.LoadUrl("http://localhost:81");
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                chromiumWebBrowser1.ExecuteScriptAsync(@"
                    let occupation = document.getElementById('occupation');
                    occupation.addEventListener('change', (e) => {
                        CefSharp.PostMessage({occupation: occupation.options[occupation.selectedIndex].text});
                    });

                    let gradDate = document.getElementById('graduation');
                    gradDate.addEventListener('input', (e) => {
                        CefSharp.PostMessage({gradDate: gradDate.value});
                    });
                ");
            }
        }

        private void chromiumWebBrowser1_JavascriptMessageReceived(object sender, JavascriptMessageReceivedEventArgs e)
        {
            var message = ((IDictionary<string, object>)e.Message).Single();
            switch (message.Key)
            {
                case "gradDate":
                    dtpGraduation.Invoke(new Action(() =>
                        dtpGraduation.Value = DateTime.TryParse(message.Value.ToString(), out var gradDate) ? gradDate : DateTime.Now
                    ));
                    break;
                case "occupation":
                    cbxOccupation.Invoke(new Action(() =>
                    {
                        if (message.Value.ToString() != "")
                            cbxOccupation.Text = message.Value.ToString();
                        else
                            cbxOccupation.SelectedIndex = -1;
                    }));
                    break;
            }
        }

        private void cbxOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            chromiumWebBrowser1.ExecuteScriptAsync($"document.getElementById('occupation').value = '{cbxOccupation.Text}';");
        }

        private void dtpGraduation_ValueChanged(object sender, EventArgs e)
        {
            chromiumWebBrowser1.ExecuteScriptAsync($"document.getElementById('graduation').value = '{dtpGraduation.Value:yyyy-MM-ddThh:mm}';");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            chromiumWebBrowser1.ExecuteScriptAsync($"document.getElementById('name').value = '{txtName.Text}';");
        }
    }

    public class FancyKeyboardHandler : IKeyboardHandler
    {
        private readonly TextBox txtName;
        private readonly DateTimePicker dtpGraduation;

        public FancyKeyboardHandler(TextBox txtName, DateTimePicker dtpGraduation)
        {
            this.txtName = txtName;
            this.dtpGraduation = dtpGraduation;
        }

        public bool OnKeyEvent(IWebBrowser chromiumWebBrowser, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey)
        {
            chromiumWebBrowser.EvaluateScriptAsync("document.getElementById('name').value;")
                              .ContinueWith(x => txtName.Invoke(new Action(() => {
                                  txtName.Text = Convert.ToString(x.Result.Result);
                              })));

            chromiumWebBrowser.EvaluateScriptAsync("document.getElementById('graduation').value;")
                              .ContinueWith(x => dtpGraduation.Invoke(new Action(() => {
                                  dtpGraduation.Value = DateTime.TryParse(x.Result.Result.ToString(), out var gradDate) ? gradDate : DateTime.Now;
                              })));

            return true;
        }

        public bool OnPreKeyEvent(IWebBrowser chromiumWebBrowser, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
        {
            // If you return true here, the keyboard event is considered 'handled', and OnKeyEvent will not fire.
            return false;
        }
    }

    public static class Utilities
    {
        public static void Apply(this Control control, Action action)
        {
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }
    }

    public class ContextMenuHandler : IContextMenuHandler
    {
        public void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            model.AddSeparator();
            model.AddItem(CefMenuCommand.CustomFirst, "Inspect");
        }

        public bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            if (commandId == CefMenuCommand.CustomFirst)
            {
                browser.ShowDevTools();
                return true;
            }

            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
        {
        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
