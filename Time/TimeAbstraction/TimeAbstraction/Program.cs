using System;
using System.Windows.Forms;

namespace TimeAbstraction
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Services.RegisterServices();
            Application.Run(new Form1());
        }
    }
}
