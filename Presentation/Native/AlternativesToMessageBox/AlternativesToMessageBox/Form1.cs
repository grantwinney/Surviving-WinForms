using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlternativesToMessageBox
{
    public partial class Form1 : Form
    {
        const string MSG_CAPTION = "Really important message";
        const string MSG_TEXT = "HALT! Read this important message!";

        frmMessages msgForm;

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabelMessage.Text = "";
        }


        // MessageBox (for the traditionalist)

        private void btnUseMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MSG_TEXT, MSG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        // NotifyIcon aka Windows notification area (when in Rome...)

        private void btnUseNotifyIcon_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(2000, MSG_CAPTION, $"{MSG_TEXT} ({DateTime.Now:h:mm:ss tt})", ToolTipIcon.Warning);
        }


        // StatusStrip (did you remember this exists?)

        readonly Queue<string> pendingMessages = new Queue<string>();

        private void btnUseStatusStrip_Click(object sender, EventArgs e)
        {
            pendingMessages.Enqueue($"{DateTime.Now:h:mm:ss.fff tt}: {MSG_TEXT}");
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            while (pendingMessages.Count > 0)
            {
                toolStripStatusLabelMessage.Text = pendingMessages.Dequeue();
                await Task.Delay(3000);
            }

            toolStripStatusLabelMessage.Text = "";
            timer1.Start();
        }


        // FlowLayoutPanel (okay, no one remembers this exists)

        private async void btnUseFlowLayoutPanel_Click(object sender, EventArgs e)
        {
            await AddMessageToPanel($"{DateTime.Now:h:mm:ss.fff tt}: {MSG_TEXT}");
        }

        private async Task AddMessageToPanel(string message)
        {
            var l = new Label { Text = message, AutoSize = true };
            flowLayoutPanelMessages.Controls.Add(l);
            await Task.Delay(3000);  // give user a few seconds to read it
            l.Dispose();
        }


        // A separate Form (hey why not)

        private void btnUseSeparateForm_Click(object sender, EventArgs e)
        {
            if (msgForm == null)
            {
                msgForm = new frmMessages();
                msgForm.Show();
            }

            frmMessages.Messages.Enqueue($"{DateTime.Now:h:mm:ss.fff tt}: {MSG_TEXT}");
        }
    }
}
