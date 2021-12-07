using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MessageBoxForDevs
{
    public partial class ExceptionalBox : Form
    {
        private readonly Exception exception;

        public ExceptionalBox(Exception exception)
            : this(exception.Message, exception) { }

        public ExceptionalBox(string userFriendlyMessage, Exception exception)
        {
            InitializeComponent();
            
            lblMessage.Text = userFriendlyMessage;
            this.exception = exception;

#if DEBUG || DEVELOPMENT || STAGING
            btnSOS.Visible = btnMS.Visible = btnCopy.Visible = btnNote.Visible = true;
#endif
        }

        private void btnSOS_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo($"https://stackoverflow.com/search?q={exception.GetType()}+{exception?.Message.Replace(' ', '+')}")
            {
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo($"https://docs.microsoft.com/en-us/search/?terms={exception.GetType()}+{exception?.Message.Replace(" ", "%20")}")
            {
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(exception.ToString());
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            var tempFile = $"{Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString())}.txt";
            File.WriteAllText(tempFile, exception.ToString());
            Process.Start("notepad.exe", tempFile);
        }
    }
}
