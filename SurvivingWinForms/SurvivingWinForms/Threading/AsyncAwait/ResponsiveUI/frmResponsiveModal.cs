﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurvivingWinForms.Threading.AsyncAwait.ResponsiveUI
{
    public partial class frmResponsiveModal : Form
    {
        public frmResponsiveModal()
        {
            InitializeComponent();
        }

        private void btnMainThread_Click(object sender, EventArgs e)
        {
            txtMainThread.Clear();
            btnMainThread.Enabled = false;
            prgMainThread.Show();

            var bmt = new BreakfastSingleThread((text) => txtMainThread.AppendText(text + Environment.NewLine));
            bmt.MakeBreakfast();

            btnMainThread.Enabled = true;
            prgMainThread.Hide();
            txtMainThread.AppendText("**** ALL DONE ****");
        }

        private async void btnSeparateThread_Click(object sender, EventArgs e)
        {
            txtSeparateThread.Clear();
            btnSeparateThread.Enabled = false;
            prgSeparateThread.Show();

            var bmt = new BreakfastSingleThread((text) =>
            {
                try
                {
                    if (txtSeparateThread.InvokeRequired)
                        txtSeparateThread.Invoke((MethodInvoker)delegate { txtSeparateThread.AppendText(text + Environment.NewLine); });
                    else
                        txtSeparateThread.AppendText(text + Environment.NewLine);
                }
                catch (ObjectDisposedException)
                {
                    // You might want to at least log the exception, depending on the case.
                }
            });

            await Task.Run(() => bmt.MakeBreakfast());

            btnSeparateThread.Enabled = true;
            prgSeparateThread.Hide();
            if (!txtSeparateThread.IsDisposed)
                txtSeparateThread.AppendText("**** ALL DONE ****");
        }

        private async void btnMultipleThreads_Click(object sender, EventArgs e)
        {
            txtMultipleThreads.Clear();
            btnMultipleThreads.Enabled = false;
            prgMultipleThreads.Show();

            var progress = new Progress<string>();
            progress.ProgressChanged += (s, message) =>
            {
                if (!txtMultipleThreads.IsDisposed)
                    txtMultipleThreads.AppendText(message + Environment.NewLine);
            };

            var bmt = new BreakfastMultipleThreads(progress);
            await Task.Run(() => bmt.MakeBreakfastAsync());

            btnMultipleThreads.Enabled = true;
            prgMultipleThreads.Hide();
            if (!txtMultipleThreads.IsDisposed)
                txtMultipleThreads.AppendText("**** ALL DONE ****");
        }
    }
}
