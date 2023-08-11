using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallingAsyncMethodFromSynchronousCode
{
    public partial class Form1 : Form
    {
        static readonly object randLock = new object();
        static readonly Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            ClearLabels();
        }

        private void ClearLabels() => lblThread1.Text = lblThread2.Text = lblThread3.Text = lblReturnValue.Text = "";

        private async Task MyShinyNewAsyncMethod(IProgress<int> progress)
        {
            await Task.WhenAll(
                CallSomeOtherAsyncMethod(progress),
                AndYetAnotherAsyncMethod(progress),
                WhyNotOneMoreAsyncMethod(progress)
            );
        }

        private async Task CallSomeOtherAsyncMethod(IProgress<int> progress)
        {
            await Task.Run(() => Thread.Sleep(GetRandomNumberThreadSafe()));

            progress.Report(1);
        }

        private async Task AndYetAnotherAsyncMethod(IProgress<int> progress)
        {
            await Task.Run(() => Thread.Sleep(GetRandomNumberThreadSafe()));

            progress.Report(2);
        }

        private async Task WhyNotOneMoreAsyncMethod(IProgress<int> progress)
        {
            await Task.Run(() => Thread.Sleep(GetRandomNumberThreadSafe()));

            progress.Report(3);
        }

        private int GetRandomNumberThreadSafe()
        {
            // https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0#the-systemrandom-class-and-thread-safety
            lock (randLock)
                return rand.Next(500, 3000);
        }



        // Example 1 - Calling async method from another async method.. async turtles all the way down

        private async void btnExample1_Click(object sender, EventArgs e)
        {
            ClearLabels();
            pnlButtons.Enabled = false;

            // https://learn.microsoft.com/en-us/dotnet/api/system.progress-1
            var progress = new Progress<int>(thread =>
                Controls.Cast<Control>().Single(x => x.Name == $"lblThread{thread}").Text = "Done!");

            await MyShinyNewAsyncMethod(progress);

            pnlButtons.Enabled = true;
        }



        // Example 2 - Calling async method from a sync method.. the code gods frown upon thee

        private void btnExample2_Click(object sender, EventArgs e)
        {
            ClearLabels();
            pnlButtons.Enabled = false;
          
            MySynchronousHillToDieOn_NoWaiting();

            pnlButtons.Enabled = true;  // OOPS! The panel will be enabled before the thread completes
        }

        private void MySynchronousHillToDieOn_NoWaiting()
        {
            var progress = new Progress<int>(thread =>
                Controls.Cast<Control>().Single(x => x.Name == $"lblThread{thread}").Text = "Done!");

            Task.Run(async () => await MyShinyNewAsyncMethod(progress));
        }



        // Example 3 - Calling async method from another sync method.. the code gods have a good cry

        private void btnExample3_Click(object sender, EventArgs e)
        {
            ClearLabels();
            pnlButtons.Enabled = false;

            MySynchronousHillToDieOn_Wait();

            pnlButtons.Enabled = true;
        }


        private void MySynchronousHillToDieOn_Wait()
        {
            var progress = new Progress<int>(thread =>
                Controls.Cast<Control>().Single(x => x.Name == $"lblThread{thread}").Text = "Done!");

            var t = Task.Run(async () => await MyShinyNewAsyncMethod(progress));
            t.Wait();
        }



        // Example 4 - Calling async method from another sync method and waiting for return value.. the code gods give up and admit you gotta do what you gotta do
        private void btnExample4_Click(object sender, EventArgs e)
        {
            ClearLabels();
            pnlButtons.Enabled = false;

            MySynchronousHillToDieOn_WaitForReturnValue();

            pnlButtons.Enabled = true;
        }

        private void MySynchronousHillToDieOn_WaitForReturnValue()
        {
            var progress = new Progress<int>(thread =>
                Controls.Cast<Control>().Single(x => x.Name == $"lblThread{thread}").Text = "Done!");

            var t = Task.Run(async () => await MyShinyNewAsyncMethodThatReturnsAValue(progress));

            lblReturnValue.Text = t.Result.ToString();
        }

        private async Task<DateTime> MyShinyNewAsyncMethodThatReturnsAValue(IProgress<int> progress)
        {
            await MyShinyNewAsyncMethod(progress);
            return DateTime.Now;
        }
    }
}
