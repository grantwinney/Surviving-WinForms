using SurvivingWinForms.Threading.AsyncAwait.ResponsiveModal;
using System;
using System.Windows.Forms;

namespace SurvivingWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void responsiveModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new frmResponsiveModal().Show();
        }
    }
}
