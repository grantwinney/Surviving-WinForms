using LegacySpaceLibrary;
using System;
using System.Threading.Tasks;

namespace TaskCompletion
{
    /// <summary>
    /// Wrapping the BackgroundWorker in a Task, to hide the implementation details of the BGW
    /// </summary>
    public class SpaceTask
    {
        private TaskCompletionSource<Tuple<ISSLocation, ISSAstronauts>> tcs = new();
        private readonly OldSpaceLibrary oldSpaceLibrary = new();

        public bool IsRunning { get; private set; }

        public void CancelTask()
        {
            oldSpaceLibrary.Worker.CancelAsync();
        }

        public Task<Tuple<ISSLocation, ISSAstronauts>> GetData(IProgress<string> progress = null)
        {
            if (IsRunning)
                throw new Exception("Task is already running. Please wait until it's complete.");

            IsRunning = true;

            oldSpaceLibrary.Worker.ProgressChanged += (s, e) =>
            {
                progress?.Report($"[{e.ProgressPercentage,3}%]: {e.UserState}");
            };

            oldSpaceLibrary.Worker.RunWorkerCompleted += (s, e) =>
            {
                if (e.Error != null)
                    tcs.SetException(e.Error);
                else if (e.Cancelled)
                    tcs.SetCanceled();
                else
                    tcs.SetResult(Tuple.Create(oldSpaceLibrary.ISSLocation, oldSpaceLibrary.ISSAstronauts));

                IsRunning = false;
            };

            oldSpaceLibrary.GetData();

            return tcs.Task;
        }
    }
}
