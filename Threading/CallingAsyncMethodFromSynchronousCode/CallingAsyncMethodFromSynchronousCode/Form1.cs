using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallingAsyncMethodFromSynchronousCode
{
    public partial class Form1 : Form
    {
        private readonly Progress<int> progress;
      
        public Form1()
        {
            InitializeComponent();

            ResetUI();
            progress = new Progress<int>(step =>
            {
                toolStripProgressBar1.Value = step;
                lblStatus.Text = $"{step}/3 complete...";
            });
        }

        private void ResetUI()
        {
            toolStripProgressBar1.Value = 0;
            lblStatus.Text = lblReturnValue.Text = "";
        }


        // Example 1 - Let's cause a deadlock
        private void btnExample1_Click(object sender, EventArgs e)
        {
            ResetUI();
          
            // As soon as we call .Result or .Wait() here, all is lost...
            var result = ImportantStuffAsync(new Progress<int>()).Result;

            // ... the UI thread is deadlocked, so just restart the app. :(
        }


        // Example 2 - Call async method from a sync method, without bothering to wait
        private void btnExample2_Click(object sender, EventArgs e)
        {
            ResetUI();
            pnlButtons.Enabled = false;

            Task.Run(() => ImportantStuffAsync(progress));

            // OOPS! The panel will be re-enabled before the Task completes
            pnlButtons.Enabled = true;
        }


        // Example 3 - Call async method from a sync method, but wait until it completes (freezes UI)
        private void btnExample3_Click(object sender, EventArgs e)
        {
            ResetUI();
            pnlButtons.Enabled = false;

            Task.Run(() => ImportantStuffAsync(progress)).Wait();

            pnlButtons.Enabled = true;
        }


        // Example 4 - Call async method from a sync method, but wait for return value
        private void btnExample4_Click(object sender, EventArgs e)
        {
            ResetUI();
            pnlButtons.Enabled = false;

            var result = Task.Run(() => ImportantStuffAsync(progress)).Result;
            lblReturnValue.Text = $"{result} Control continues on Thread {Environment.CurrentManagedThreadId}.";

            pnlButtons.Enabled = true;
        }


        // Example 5 - Call async method from another async method.. the right way
        private async void btnExample5_Click(object sender, EventArgs e)
        {
            ResetUI();
            pnlButtons.Enabled = false;

            var result = await ImportantStuffAsync(progress);

            lblReturnValue.Text = $"{result} Control continues on Thread {Environment.CurrentManagedThreadId}.";
            pnlButtons.Enabled = true;
        }


        /// <summary>
        /// An async method that does some REALLY important stuff
        /// </summary>
        /// <param name="progress">An IProgress, for reporting progress back to the calling thread</param>
        /// <returns>The final status</returns>
        public async Task<string> ImportantStuffAsync(IProgress<int> progress)
        {
            await Task.Delay(1000);
            progress.Report(1);

            await Task.Delay(1000);
            progress.Report(2);

            await Task.Delay(1000);
            progress.Report(3);

            return $"({DateTime.Now:G}) Task done running on Thread {Environment.CurrentManagedThreadId}.";
        }
    }
}
