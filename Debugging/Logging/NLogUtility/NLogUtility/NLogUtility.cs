using NLog;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace NLogUtility
{
    public partial class NLogUtility : Form
    {
        readonly string logFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "logs");
        readonly Logger logger;

        public NLogUtility()
        {
            InitializeComponent();

            void WriteFile(object o, FileSystemEventArgs e)
            {
                txtFileContents.Text = File.ReadAllText(Path.Combine(logFilePath, "AppLog.txt"));
                txtFileContents.SelectionStart = txtFileContents.Text.Length;
                txtFileContents.ScrollToCaret();
            };

            logWatcher.Changed += WriteFile;
            logWatcher.Created += WriteFile;
            logWatcher.Deleted += (o, e) => txtFileContents.Text = "";

            logger = LogManager.GetLogger("app_logger");
        }

        private void NLogUtility_Load(object sender, EventArgs e)
        {
            logWatcher.Path = logFilePath;
            logWatcher.EnableRaisingEvents = true;
        }

        private void btnLogException_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                var result = 5 / num;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ruh roh. An error occurred!");
            }
        }

        private void btnLogInfo_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text != "" ? txtMessage.Text : "Informational message goes here.";

            if (chkIncludeStackTrace.Checked)
                logger.Info($"{message} {new StackTrace()}");
            else
                logger.Info(message);
        }

        private void btnLogTrace_Click(object sender, EventArgs e)
        {
            logger.Trace($"{Environment.NewLine} User pressed the LogTrace button {new StackTrace()}");
        }
    }
}
