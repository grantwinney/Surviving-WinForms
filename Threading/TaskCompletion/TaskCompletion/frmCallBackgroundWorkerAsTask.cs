using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskCompletion
{
    /// <summary>
    /// Calling the Task provided by the SpaceTask class that hides the BackgroundWorker.
    /// </summary>
    public partial class frmCallBackgroundWorkerAsTask : Form
    {
        SpaceTask task;

        public frmCallBackgroundWorkerAsTask()
        {
            InitializeComponent();
        }

        private async void btnGetData_Click(object sender, EventArgs e)
        {
            if (task?.IsRunning ?? false)
            {
                task.CancelTask();
                btnGetData.Enabled = false;
                return;
            }

            btnGetData.Text = "Cancel operation";
            prgStatus.Value = 0;
            prgStatus.Show();
            txtStatus.Text = "Retrieving ISS data...\r\n\r\n";

            try
            {
                var progressHandler = new Progress<string>(statusUpdate =>
                {
                    txtStatus.AppendText($"{statusUpdate}\r\n");
                });

                task = new();

                var data = await task.GetData(progressHandler);

                var location = data.Item1.Position;
                var astronauts = data.Item2.People;
                txtStatus.AppendText($"\r\nThe ISS is positioned over ({location.Latitude}, {location.Longitude}) with {astronauts.Count} astronauts aboard.\r\n\r\n");
            }
            catch (TaskCanceledException)
            {
                txtStatus.AppendText("Cancelled!");
            }
            catch (Exception ex)
            {
                txtStatus.AppendText($"Failed: {ex.Message}");
            }

            btnGetData.Text = "Get Latest ISS Data (task)";
            btnGetData.Enabled = true;
            prgStatus.Hide();
        }
    }
}
