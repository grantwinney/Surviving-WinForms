using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;

namespace LegacySpaceLibrary
{
    public class OldSpaceLibrary
    {
        public readonly BackgroundWorker Worker = new BackgroundWorker { WorkerReportsProgress = true, WorkerSupportsCancellation = true };

        public ISSLocation ISSLocation { get; private set; }
        public ISSAstronauts ISSAstronauts { get; private set; }

        public OldSpaceLibrary()
        {
            Worker.DoWork += Worker_DoWork;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        public void GetData()
        {
            if (Worker.IsBusy)
                return;

            ISSLocation = null;
            ISSAstronauts = null;

            Worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Worker.ReportProgress(0, "Requesting data...");
          
            Thread.Sleep(2000);   
            if (Worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            var issLocation = JsonConvert.DeserializeObject<ISSLocation>(
                GetDataAsString("http://api.open-notify.org/iss-now.json"));
            Worker.ReportProgress(25, "1/2 requests done.");

            Thread.Sleep(2000);
            if (Worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            var issAstronauts = JsonConvert.DeserializeObject<ISSAstronauts>(
                GetDataAsString("http://api.open-notify.org/astros.json"));
            issAstronauts.People.RemoveAll(x => x.Craft != "ISS");
            Worker.ReportProgress(50, "2/2 requests done.");
            Worker.ReportProgress(75, "Processing data...");

            Thread.Sleep(2000);
            if (Worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            Worker.ReportProgress(100, "Processing complete!");

            e.Result = new List<object> { issLocation, issAstronauts };
        }

        private string GetDataAsString(string endpoint)
        {
            var request = WebRequest.Create(endpoint);
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var dataStream = response.GetResponseStream())
            using (var reader = new StreamReader(dataStream))
                return reader.ReadToEnd();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                var data = (List<object>)e.Result;
                ISSLocation = (ISSLocation)data[0];
                ISSAstronauts = (ISSAstronauts)data[1];
            }
        }
    }
}
