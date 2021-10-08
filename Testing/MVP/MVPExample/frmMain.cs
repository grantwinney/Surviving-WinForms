using MVPExample.Models;
using MVPExample.Presenters;
using System;
using System.Windows.Forms;

namespace MVPExample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLaunchCalculator_Click(object sender, EventArgs e)
        {
            new CalcPresenter(new CalcForm(), new CalcModel());
        }
    }
}
