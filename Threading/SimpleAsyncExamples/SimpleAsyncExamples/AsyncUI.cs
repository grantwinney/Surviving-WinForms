namespace SimpleAsyncExamples;

public partial class AsyncUI : Form
{
    public AsyncUI()
    {
        InitializeComponent();

        foreach (var label in Controls.OfType<GroupBox>().SelectMany(c => c.Controls.OfType<Label>().Where(c => c.Name.StartsWith("lblStatusAsync"))))
            label.Text = "";
    }


    // Ex 1: Runs 5-second task and then completes

    private async void btnRunTask1_Click(object sender, EventArgs e)
    {
        btnRunTask1.Enabled = false;
        lblStatusAsync1.Text = "Running...";

        try
        {
            await SimpleAsyncMethods.Example1Async();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        btnRunTask1.Enabled = true;
        lblStatusAsync1.Text = "Completed!";
    }


    // Ex 2: Runs 5-second task for 3 seconds and then cancels it
    //  A CancellationTokenSource can be automatically canceled after a set delay

    private async void btnRunTask2_Click(object sender, EventArgs e)
    {
        // By using 'using', the CancellationTokenSource will be disposed of automatically
        using CancellationTokenSource cancelTokenSource2 = new(TimeSpan.FromSeconds(3));

        btnRunTask2.Enabled = false;
        lblStatusAsync2.Text = "Running...";

        try
        {
            await SimpleAsyncMethods.Example2Async(cancelTokenSource2.Token);
            lblStatusAsync2.Text = "Completed!";
        }
        catch (OperationCanceledException)
        {
            // We can catch the OperationCanceledException and act on that
            lblStatusAsync2.Text = "Canceled!";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnRunTask2.Enabled = true;
        }
    }


    // Ex 3: Runs 10-second task, during which it can be canceled

    CancellationTokenSource _cancelTokenSource3;

    private async void btnRunTask3_Click(object sender, EventArgs e)
    {
        _cancelTokenSource3 = new();
        btnRunTask3.Enabled = false;
        btnCancelTask3.Enabled = true;
        lblStatusAsync3.Text = "Running...";

        // Instead of catching the OperationCanceledException, we can register some code to run if the token is canceled.
        _cancelTokenSource3.Token.Register(() => lblStatusAsync3.Text = "Canceled!");

        try
        {
            await SimpleAsyncMethods.Example3Async(_cancelTokenSource3.Token);
            lblStatusAsync3.Text = "Completed!";
        }
        catch (Exception ex)
        {
            // Since cancellation is being handled by Register() above, we'll ignore it here
            if (ex is not OperationCanceledException)
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnRunTask3.Enabled = true;
            btnCancelTask3.Enabled = false;

            // Dispose of the CancellationTokenSource to free up resources
            _cancelTokenSource3.Dispose();
        }
    }

    private void btnCancelTask3_Click(object sender, EventArgs e)
    {
        _cancelTokenSource3.Cancel();
    }


    // Ex 4: Runs task indefinitely, during which it can be manually canceled

    CancellationTokenSource _cancelTokenSource4;

    private async void btnRunTask4_Click(object sender, EventArgs e)
    {
        _cancelTokenSource4 = new();
        btnRunTask4.Enabled = false;
        btnCancelTask4.Enabled = true;
        lblStatusAsync4.Text = "Running...";

        _cancelTokenSource4.Token.Register(() => lblStatusAsync4.Text = "Canceled!");

        try
        {
            await SimpleAsyncMethods.Example4Async(_cancelTokenSource4.Token);
            lblStatusAsync4.Text = "Completed!";
        }
        catch (OperationCanceledException)
        {
            // Eat the exception or, assuming exceptions bubble up to be handled elsewhere (i.e. logging),
            //  remove this catch and allow it to be handled the same way
        }
        finally
        {
            btnRunTask4.Enabled = true;
            btnCancelTask4.Enabled = false;
            _cancelTokenSource4.Dispose();
        }
    }

    private void btnCancelTask4_Click(object sender, EventArgs e)
    {
        _cancelTokenSource4.Cancel();
    }


    // Ex 5: Runs 10-second task that's cancellable AND reports progress as it runs

    CancellationTokenSource _cancelTokenSource5;

    private async void btnRunTask5_Click(object sender, EventArgs e)
    {
        _cancelTokenSource5 = new();
        btnRunTask5.Enabled = false;
        btnCancelTask5.Enabled = true;
        progBarTask5.Value = 0;
        lblStatusAsync5.Text = "Running...";
        var progress = new Progress<(int percentage, string message)>();

        progress.ProgressChanged += (_, update) =>
        {
            lblStatusAsync5.Text = update.message;
            progBarTask5.Value = update.percentage;
        };

        try
        {
            await SimpleAsyncMethods.Example5Async(_cancelTokenSource5.Token, progress);
        }
        catch (OperationCanceledException)
        {
            // eat the exception.. nom nom nom
        }
        finally
        {
            btnRunTask5.Enabled = true;
            btnCancelTask5.Enabled = false;
            _cancelTokenSource5.Dispose();
        }
    }

    private void btnCancelTask5_Click(object sender, EventArgs e)
    {
        _cancelTokenSource5.Cancel();
    }
}
