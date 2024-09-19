using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class frmResponsiveModal : Form
    {
        public frmResponsiveModal()
        {
            InitializeComponent();
        }

        private void btnMainThread_Click(object sender, EventArgs e)
        {
            txtMainThread.Clear();
            btnMainThread.Enabled = false;
            prgMainThread.Show();

            var bmt = new BreakfastSingleThread((text) => txtMainThread.AppendText(text + Environment.NewLine));
            bmt.MakeBreakfast();

            btnMainThread.Enabled = true;
            prgMainThread.Hide();
            txtMainThread.AppendText("**** ALL DONE ****");
        }

        private async void btnSeparateThread_Click(object sender, EventArgs e)
        {
            txtSeparateThread.Clear();
            btnSeparateThread.Enabled = false;
            prgSeparateThread.Show();

            var bst = new BreakfastSingleThread((text) =>
            {
                try
                {
                    if (txtSeparateThread.InvokeRequired)
                        txtSeparateThread.Invoke((MethodInvoker)delegate { txtSeparateThread.AppendText(text + Environment.NewLine); });
                    else
                        txtSeparateThread.AppendText(text + Environment.NewLine);
                }
                catch (ObjectDisposedException)
                {
                    // You might want to at least log the exception, depending on the case.
                }
            });

            await Task.Run(() => bst.MakeBreakfast());

            btnSeparateThread.Enabled = true;
            prgSeparateThread.Hide();
            if (!txtSeparateThread.IsDisposed)
                txtSeparateThread.AppendText("**** ALL DONE ****");
        }

        private async void btnMultipleThreads_Click(object sender, EventArgs e)
        {
            txtMultipleThreads.Clear();
            btnMultipleThreads.Enabled = false;
            prgMultipleThreads.Show();

            var progress = new Progress<string>();
            progress.ProgressChanged += (s, message) =>
            {
                if (!txtMultipleThreads.IsDisposed)
                    txtMultipleThreads.AppendText(message + Environment.NewLine);
            };

            var bmt = new BreakfastMultipleThreads(progress);
            await bmt.MakeBreakfastAsync();

            btnMultipleThreads.Enabled = true;
            prgMultipleThreads.Hide();
            if (!txtMultipleThreads.IsDisposed)
                txtMultipleThreads.AppendText("**** ALL DONE ****");
        }

        private async void btnMultipleThreadsHeavy_Click(object sender, EventArgs e)
        {
            txtMultipleThreadsHeavy.Clear();
            btnMultipleThreadsHeavy.Enabled = false;
            prgMultipleThreadsHeavy.Show();

            var progress = new Progress<string>();
            progress.ProgressChanged += (s, message) =>
            {
                if (!txtMultipleThreadsHeavy.IsDisposed)
                    txtMultipleThreadsHeavy.AppendText(message + Environment.NewLine);
            };

            var bhr = new BreakfastHeavilyDigested(progress);
            await bhr.MakeBreakfastAsync();

            btnMultipleThreadsHeavy.Enabled = true;
            prgMultipleThreadsHeavy.Hide();
            if (!txtMultipleThreadsHeavy.IsDisposed)
                txtMultipleThreadsHeavy.AppendText("**** ALL DONE ****");

        }
    }
}
