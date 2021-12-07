using MessageBoxForDevs.Misc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MessageBoxForDevs
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

#if DEBUG
            Text += " - DEBUG";
#elif DEVELOPMENT
            Text += " - DEVELOPMENT";
#elif STAGING
            Text += " - STAGING";
#endif
        }

        private void btnDivisionByZero_Click(object sender, EventArgs e)
        {
            try
            {
                var answer = PerformDivisionByZero();
            }
            catch (Exception ex)
            {
                var error = new ExceptionalBox(ex);
                error.ShowDialog();
            }
        }

        private int PerformDivisionByZero()
        {
            var lc = new LameCalculator();
            return lc.DivideByZero();
        }

        private void btnOpenMissingFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenSomeFile();
            }
            catch (Exception ex)
            {
                var error = new ExceptionalBox(ex);
                error.ShowDialog();
            }
        }

        private FileStream OpenSomeFile()
        {
            var lfo = new LameFileOpener();
            return lfo.GimmeThatFile();
        }

        private void btnIndexOutOfRangeException_Click(object sender, EventArgs e)
        {
            try
            {
                var lastItem = GetLastItem(new[] { "one", "two", "three" });
            }
            catch (Exception ex)
            {
                var error = new ExceptionalBox(ex);
                error.ShowDialog();
            }
        }

        private string GetLastItem(IList<string> list)
        {
            return list[list.Count()];  // What's zero-based indexing?
        }

        private void btnNeverGonnaWork_Click(object sender, EventArgs e)
        {
            try
            {
                var lv = new LameValidator();
                var isValid = lv.VerifyNumberInRange(int.TryParse(txtInput.Text, out int result) ? result : 0);
            }
            catch (Exception ex)
            {
                var error = new ExceptionalBox("Let's face it, this was never gonna work...", ex);
                error.ShowDialog();
            }
        }
    }
}