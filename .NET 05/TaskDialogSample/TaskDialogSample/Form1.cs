using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace TaskDialogSample;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnMessageBoxConfirmAction_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            caption: "Continue?",
            text: "You're about to delete the selected files! Continue?",
            icon: MessageBoxIcon.Warning,
            buttons: MessageBoxButtons.YesNo,
            defaultButton: MessageBoxDefaultButton.Button2);

        if (result == DialogResult.Yes)
        {
            // proceed to delete files...
        }
    }

    private void btnTaskDialogConfirmAction_Click(object sender, EventArgs e)
    {
        var result = TaskDialog.ShowDialog(new TaskDialogPage
        {
            Caption = "Continue?",
            Text = "You're about to delete the selected files! Continue?",
            Icon = TaskDialogIcon.Warning,
            Buttons = { TaskDialogButton.Yes, TaskDialogButton.No },
            DefaultButton = TaskDialogButton.No,
            SizeToContent = true,
        });

        if (result == TaskDialogButton.Yes)
        {
            // proceed to delete files...
        }
    }

    private void btnTaskDialogShowException_Click(object sender, EventArgs e)
    {
        var zero = 0;
        var wompwomp = 3 / zero;

        // see the Application_ThreadException method in the Program class
    }

    private void btnTaskDialogAcceptEULA_Click(object sender, EventArgs e)
    {
        var eulaSummary = "To accept the following EULA, check the box and press OK. " +
            "The full version of the EULA is available below if you'd like to read " +
            "it, but let's not kid ourselves.";
        var eulaDetail = "By using our product, you agree to follow all applicable " +
            "and unapplicable laws, regulations, and questionable ideas, as well as " +
            "all future laws hencetoforth unbeknownst to us, you, or the guy standing " +
            "RIGHT BEHIND YOU. Use of this software is prohibited in times of nuclear " +
            "fallout or any day not ending in 'Y'. Oh, and if you're 3 days late on " +
            "your annual subscription, we'll hold your soul as collateral.";

        var vcb = new TaskDialogVerificationCheckBox("Accept EULA");
        var tdp = new TaskDialogPage
        {
            Caption = "Accept EULA",
            Heading = "EULA",
            Text = eulaSummary,
            Footnote = $@"© <a href=""https://example.org/"">ShadyBiz LLC</a>, 2013 - {DateTime.Now.Year}",
            Icon = TaskDialogIcon.ShieldWarningYellowBar,
            AllowCancel = true,
            Expander = new TaskDialogExpander
            {
                Text = eulaDetail,
                CollapsedButtonText = "Nothing to see here...",
            },
            Buttons = { new TaskDialogButton("OK", false) },
            SizeToContent = true,
            EnableLinks = true,
            Verification = vcb,
        };

        vcb.CheckedChanged += (s, e) => tdp.Buttons[0].Enabled = vcb.Checked;
        tdp.LinkClicked += (s, e) => Process.Start("explorer", e.LinkHref);

        if (TaskDialog.ShowDialog(this, tdp) == TaskDialogButton.OK)
        {
            // record the user's acceptance of the EULA
        }
    }

    private void btnTaskDialogWaitAwhile_Click(object sender, EventArgs e)
    {
        var pb = new TaskDialogProgressBar { Value = 5, Minimum = 0, Maximum = 5 };
        var msg = "This message will self-destruct in {0} seconds...";

        var tdp = new TaskDialogPage
        {
            Caption = "Final Countdown",
            Text = string.Format(msg, 5),
            ProgressBar = pb,
            Icon = TaskDialogIcon.Information,
        };

        var tmr = new Timer() { Interval = 1000, Enabled = true };
        tmr.Tick += (s, e) =>
        {
            if (pb.Value > 0)
            {
                pb.Value -= 1;
                tdp.Text = string.Format(msg, pb.Value);
            }
            else
                tdp.Text = "Boom? ¯\\_(ツ)_/¯";
        };

        var tdResult = TaskDialog.ShowDialog(this, tdp);

        if (pb.Value == 0)
        {
            // You were warned...
        }
    }
}
