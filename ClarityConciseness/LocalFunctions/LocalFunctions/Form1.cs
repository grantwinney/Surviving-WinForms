using System;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

/// <summary>
/// https://grantwinney.com/local-functions-in-csharp-aka-nested-methods
/// </summary>
namespace LocalFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Set textboxes one at a time; can we do better?

            if (txtTitle.Text == string.Empty)
                txtTitle.Text = "N/A";
            if (txtAddr2.Text == string.Empty)
                txtAddr2.Text = "N/A";
            if (txtAddr3.Text == string.Empty)
                txtAddr3.Text = "N/A";
            if (txtState.Text == string.Empty)
                txtState.Text = "N/A";
            if (txtProvince.Text == string.Empty)
                txtProvince.Text = "N/A";
            if (txtPrevEmp2.Text == string.Empty)
                txtPrevEmp2.Text = "N/A";
            if (txtPrevEmp3.Text == string.Empty)
                txtPrevEmp3.Text = "N/A";
            if (txtWorkRef2.Text == string.Empty)
                txtWorkRef2.Text = "N/A";
            if (txtWorkRef3.Text == string.Empty)
                txtWorkRef3.Text = "N/A";


            // First attempt at a local function - still readable
          
            void SetNAIfEmpty1(TextBox textBox)
            {
                if (textBox.Text == string.Empty)
                    textBox.Text = "N/A";
            }

            SetNAIfEmpty1(txtTitle);
            SetNAIfEmpty1(txtAddr2);
            SetNAIfEmpty1(txtAddr3);
            SetNAIfEmpty1(txtState);
            SetNAIfEmpty1(txtProvince);
            SetNAIfEmpty1(txtPrevEmp2);
            SetNAIfEmpty1(txtPrevEmp3);
            SetNAIfEmpty1(txtWorkRef2);
            SetNAIfEmpty1(txtWorkRef3);


            // Second attempt at a local function - not quite as readable

            SetNAIfEmpty2(txtTitle, txtAddr2, txtAddr3, txtState, txtProvince,
                txtPrevEmp2, txtPrevEmp3, txtWorkRef2, txtWorkRef3);

            void SetNAIfEmpty2(params TextBox[] textBoxes)
            {
                foreach (var textBox in textBoxes)
                    if (textBox.Text == string.Empty)
                        textBox.Text = "N/A";
            }


            // More than one way - LINQ

            foreach (var textBox in pnlContactInfo.Controls.OfType<TextBox>().Where(tb => tb.Text == string.Empty))
                textBox.Text = "N/A";
        }


        // You can create them in a property setter too
        public string SomeProperty
        {
            get
            {
                string ButWhy() => "why not";

                return ButWhy();
            }
        }


        // Local functions for recursion - calculating factorials
        private void btnCalcFactorial_Click(object sender, EventArgs e)
        {
            txtFactorialResult.Text = GetFactorial(Convert.ToInt32(txtFactorialStart.Text)).ToString();
            
            BigInteger GetFactorial(int number)
            {
                if (number == 1)
                    return 1;

                return number * GetFactorial(number - 1);
            }
        }


        // Local functions for recursion - calculating loans
        private void btnCalcTotalRepaid(object sender, EventArgs e)
        {
            var totalRepaidAmount = GetTotalRepaidAmount(Convert.ToDecimal(txtOrigLoan.Text),
                Convert.ToDecimal(txtMonthlyInt.Text) / 100, Convert.ToInt32(txtNbrOfMonths.Text));
            txtTotalRepaid.Text = $"${totalRepaidAmount:0.00}";

            decimal GetTotalRepaidAmount(decimal amount, decimal interest, int months)
            {
                if (months == 0)
                    return amount;

                return GetTotalRepaidAmount(amount * (1 + interest), interest, --months);
            }
        }


        // Yo, I heard you like functions in your functions, so here's a function in the function in your function...
        private void HowAreYouFeelingToday()
        {
            Console.WriteLine($"I'm feeling {EvenOrOdd()} today.");

            string EvenOrOdd()
            {
                return PositiveOrNegative() > 0 ? "even" : "odd";

                int PositiveOrNegative()
                {
                    return IsDayEven() ? 1 : -1;

                    bool IsDayEven()
                    {
                        return DateTime.Now.DayOfYear % 2 == 0;
                    }
                }
            }
        }


        private void TheWorldIsYourTurtle(int turtles)
        {
            Console.WriteLine($"The world sits{OnATurtle("", turtles)}.");

            string OnATurtle(string message, int number)
            {
                if (number == 0)
                    return message;

                return OnATurtle(message + " on a turtle", --number);
            }
        }
    }
}
