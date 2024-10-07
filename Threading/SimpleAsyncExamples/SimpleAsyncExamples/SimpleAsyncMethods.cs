namespace SimpleAsyncExamples;

internal class SimpleAsyncMethods
{
    // Ex 1: Task.Delay is an easy way to simulate a long-running job

    public static async Task Example1Async()
    {
        await Task.Delay(5000);
    }

    // Ex 2: By periodically calling ThrowIfCancellationRequested, we effectively check for a
    //  pending cancellation and throw an OperationCanceledException with a single line of code

    public static async Task Example2Async(CancellationToken cToken)
    {
        for (var i = 0; i < 5; i++)
        {
            cToken.ThrowIfCancellationRequested();
            await Task.Delay(1000);
        }
    }

    // Ex 3: CancellationToken can be passed to, and handled by, other .NET classes that accept it 

    public static async Task Example3Async(CancellationToken cToken)
    {
        for (var i = 0; i < 20; i++)
        {
            await Task.Delay(500, cToken);
        }
    }

    // Ex 4: A task can run indefinitely until its canceled

    public static async Task Example4Async(CancellationToken cToken)
    {
        while (true)
        {
            cToken.ThrowIfCancellationRequested();
            await Task.Delay(100);
        }
    }

    // Ex 5: By checking IsCancellationRequested, we can cancel a long-running task
    //  Also, the IProgress<T> construct lets us pass progress updates to the caller

    public static async Task Example5Async(CancellationToken cToken, IProgress<(int,string)> progress)
    {
        var secondsToRun = 10m;

        for (var i = 0; i < secondsToRun; i++)
        {
            var percentage = (int)((i + 1) / secondsToRun * 100);

            await Task.Delay(1000);

            // If we want to perform some additional logic on cancellation,
            //  we can throw an OperationCanceledException instead of using ThrowIfCancellationRequested
            if (cToken.IsCancellationRequested && percentage != 100)
            {
                progress.Report((percentage, $"Canceled at {percentage}%"));
                throw new OperationCanceledException("Ex 5 Canceled!", cToken);
            }
            else
                progress.Report((percentage, $"{percentage}% Complete!"));
        }
    }
}
