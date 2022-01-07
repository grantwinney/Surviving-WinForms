using System;
using System.Windows.Forms;

namespace MockingMessageBox
{
    public partial class Form1 : Form
    {
        private readonly IMessagePrompt messagePrompt;

        public Form1()
        {
            InitializeComponent();

            messagePrompt = DependencyInjector.Retrieve<IMessagePrompt>();
        }

        public Form1(IMessagePrompt msgPrompt)
        {
            InitializeComponent();

            messagePrompt = msgPrompt;
        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            ShowBroadcastMessage();
        }

        public void ShowBroadcastMessage()
        {
            messagePrompt.Show("This is just a test of the emergency broadcast system.", "Fancy App");
        }
    }
}
