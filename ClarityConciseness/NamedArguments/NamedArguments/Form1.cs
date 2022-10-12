using System;
using System.Windows.Forms;

/// <summary>
/// https://grantwinney.com/named-arguments-in-c-pass-what-you-want-and-forget-the-rest
/// </summary>
namespace NamedArguments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chkIsTerminated.CheckedChanged += (s, e) => dtpTermDate.Enabled = IsTerminated;
        }

        public bool IsTerminated
        {
            get => chkIsTerminated.Checked;
        }

        public DateTime? TerminationDate
        {
            get => IsTerminated ? (DateTime?)dtpTermDate.Value : null;
        }

        private void btnSaveOld_Click(object sender, EventArgs e)
        {
            // < C# 4 - required to pass a value to all optional parameters leading up to the one you're interested in
            
            ConfirmSave(txtUsername.Text, dtpHireDate.Value, TerminationDate, null, false, false, 3.14m, 10);
        }

        private void btnSave40_Click(object sender, EventArgs e)
        {
            // C# 4.0 - provide names for optional parameters, to pass values for only those you're actually interested in
            //        - positional parameters must come *before* any named optional parameters
            
            ConfirmSave(txtUsername.Text, dtpHireDate.Value, isTuesday: true, three: 5);
        }

        private void btnSave72_Click(object sender, EventArgs e)
        {
            // C# 7.2 - named parameters can be followed by positional parameters

            ConfirmSave(justDoIt: true, userName: txtUsername.Text, hireDate: dtpHireDate.Value, termDate: TerminationDate);
        }

        private void ConfirmSave(string userName, DateTime hireDate, DateTime? termDate = null,
            string message = "It might be unwise to save today. Continue?", bool isTuesday = false,
            bool isFullMoon = false, decimal pi = 3.14m, int three = 4, bool justDoIt = false)
        {
            if (justDoIt)
            {
                // db.Save(...);
            }
            else if (isTuesday && !isFullMoon && three == 5)
            {
                if (MessageBox.Show(message, "Are you sure about this?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // db.Save(...);
                }
            }
            else if (pi <= 3.14m)
            {
                // db.Save(...);
            }
        }
    }

    class Movie
    {
        public Movie()
        {
            AddMovie("WarGames", "Is it a game, or is it real?", "1983", "1979", "1984", "1998", "1983");

            // Providing the names kinda self-documents things...
            AddMovie(
                title: "WarGames",
                tagLine: "Is it a game, or is it real?",
                productionYear: "1979",
                releaseYear: "1983",
                soundtrackRelease: "1983",
                consoleGameRelease: "1984",
                pcGameRelease: "1998"
            );
        }

        private void AddMovie(string title, string tagLine, string releaseYear, string productionYear,
            string consoleGameRelease, string pcGameRelease, string soundtrackRelease)
        {

        }
    }
}
