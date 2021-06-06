using System;
using System.Windows.Forms;
using SurvivingWinForms.Threading.AsyncAwait.ResponsiveUI;

namespace SurvivingWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void responsiveUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new frmResponsiveModal().Show();
        }
    }
}
