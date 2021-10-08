using System;
using System.Windows.Forms;
using SurvivingWinForms.Testing.MVP.Calculator;
using SurvivingWinForms.Testing.MVP.Calculator.Models;
using SurvivingWinForms.Testing.MVP.Calculator.Presenters;
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

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalcPresenter(new CalcForm(), new CalcModel());
        }
    }
}
