using NLog;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MultipleNLogTargets
{
    internal static class Program
    {
        private static Logger logger = LogManager.GetLogger("");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            logger.Log(LogLevel.Fatal, e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            logger.Log(LogLevel.Fatal, e.ExceptionObject);
        }
    }
}
