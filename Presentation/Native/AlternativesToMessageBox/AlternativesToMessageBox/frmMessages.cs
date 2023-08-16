using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Windows.Forms;

namespace AlternativesToMessageBox
{
    public partial class frmMessages : Form
    {
        public static readonly ConcurrentQueue<string> Messages = new ConcurrentQueue<string>();

        public frmMessages()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            while (Messages.Any())
                if (Messages.TryDequeue(out var message))
                {
                    var l = new Label { Text = $"{message} (click to dismiss)", AutoSize = true, Padding = new Padding(3) };
                    l.Click += (s, evt) => { l.Dispose(); if (flowLayoutPanel1.Controls.Count == 0) Hide(); };
                    flowLayoutPanel1.Controls.Add(l);
                    Show();
                }

            timer1.Start();
        }
    }
}
