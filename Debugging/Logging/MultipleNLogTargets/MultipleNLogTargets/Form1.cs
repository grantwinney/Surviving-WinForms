using NLog;
using RestSharp;
using System;
using System.Windows.Forms;

namespace MultipleNLogTargets
{
    public partial class Form1 : Form
    {
        private readonly Logger logger;

        public Form1()
        {
            InitializeComponent();

            logger = LogManager.GetLogger("");
        }

        private void btnLogTrace_Click(object sender, EventArgs e)
        {
            logger.Log(LogLevel.Trace, txtMessage.Text);
        }


        private void btnLogDebug_Click(object sender, EventArgs e)
        {
            logger.Log(LogLevel.Debug, txtMessage.Text);
        }

        private void btnLogInfo_Click(object sender, EventArgs e)
        {
            logger.Log(LogLevel.Info, txtMessage.Text);
        }

        private void btnLogWarning_Click(object sender, EventArgs e)
        {
            logger.Log(LogLevel.Warn, txtMessage.Text);
        }

        private void btnLogException_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception(txtMessage.Text);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex);
            }
        }

        private void btnLogCritical_Click(object sender, EventArgs e)
        {
            throw new Exception(txtMessage.Text);
        }
    }
}
