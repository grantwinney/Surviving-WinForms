using LegacySpaceLibrary;
using System;
using System.Windows.Forms;

namespace TaskCompletion
{
    /// <summary>
    /// Using the BackgroundWorker as provided in the "legacy space library" class.
    /// </summary>
    public partial class frmCallBackgroundWorker : Form
    {
        private readonly OldSpaceLibrary oldSpaceLibrary = new();

        public frmCallBackgroundWorker()
        {
            InitializeComponent();

            oldSpaceLibrary.Worker.ProgressChanged += Worker_ProgressChanged;
            oldSpaceLibrary.Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (oldSpaceLibrary.Worker.IsBusy)
            {
                oldSpaceLibrary.Worker.CancelAsync();
                btnGetData.Enabled = false;
                return;
            }

            btnGetData.Text = "Cancel operation";
            prgStatus.Value = 0;
            prgStatus.Show();
            txtStatus.Text = "Retrieving ISS data...\r\n\r\n";

            oldSpaceLibrary.GetData();
        }

        private void Worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            txtStatus.AppendText($"[{e.ProgressPercentage,3}%]: {e.UserState}\r\n");
            prgStatus.Value = e.ProgressPercentage;
        }

        private void Worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                txtStatus.AppendText($"Failed: {e.Error.Message}");
            else if (e.Cancelled)
                txtStatus.AppendText("Cancelled!");
            else
            {
                var location = oldSpaceLibrary.ISSLocation.Position;
                var astronauts = oldSpaceLibrary.ISSAstronauts.People;
                txtStatus.AppendText($"\r\nThe ISS is positioned over ({location.Latitude}, {location.Longitude}) with {astronauts.Count} astronauts aboard.");
            }

            btnGetData.Text = "Get Latest ISS Data";
            btnGetData.Enabled = true;
            prgStatus.Hide();
        }
    }
}
