using MVPExample.Interfaces;
using System;
using System.Windows.Forms;

namespace MVPExample
{
    public partial class CalcForm : Form, ICalcView
    {
        public event EventHandler Add;
        public event EventHandler Reset;

        public CalcForm()
        {
            InitializeComponent();

            btnAdd.Click += (s, e) => Add.Invoke(s, e);
            btnReset.Click += (s, e) => Reset.Invoke(s, e);
        }

        string ICalcView.Value1
        {
            get => txtNumber1.Text;
            set => txtNumber1.Text = value;
        }
        string ICalcView.Value2
        {
            get => txtNumber2.Text;
            set => txtNumber2.Text = value;
        }
        string ICalcView.Value3
        {
            get => txtNumber3.Text;
            set => txtNumber3.Text = value;
        }

        public string Total
        {
            set => txtTotal.Text = value;
        }
        public string RunningTotal
        {
            set => txtRunningTotal.Text = value;
        }

        public void SetFocusOnFirstTextBox()
        {
            txtNumber1.Focus();
        }
    }
}
