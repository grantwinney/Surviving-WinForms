using System;
using System.Windows.Forms;

namespace MessageBoxForDevs
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new frmMain());
        }
    }
}