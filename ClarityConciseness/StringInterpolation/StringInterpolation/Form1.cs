using System;
using System.Windows.Forms;

/// <summary>
/// https://grantwinney.com/using-string-interpolation-to-craft-readable-strings
/// </summary>
namespace StringInterpolation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // string concatenation
            // https://docs.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings
            var message1 = txtName.Text + ", whose birthday is " + dtpBirthday.Value.ToString("d") + " and favorite number is "+ numLuckyNumber.Value 
                + ", is " + (rdoYes.Checked ? "tolerating" : "dreading") + " WinForms, hanging on with a steady flow of " + cboBeverage.Text.ToLower() + ".";


            // string format
            // https://docs.microsoft.com/en-us/dotnet/api/system.string.format
            var message2 = string.Format("{0}, whose birthday is {1:d} and favorite number is {2}, is {3} WinForms, hanging on with a steady flow of {4}.",
                txtName.Text, dtpBirthday.Value, numLuckyNumber.Value, rdoYes.Checked ? "tolerating" : "dreading", cboBeverage.Text.ToLower());


            // string interpolation
            // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation
            var message3 = $"{txtName.Text}, whose birthday is {dtpBirthday.Value:d} and favorite number is {numLuckyNumber.Value}, "
                + $"is {(rdoYes.Checked ? "tolerating" : "dreading")} WinForms, hanging on with a steady flow of {cboBeverage.Text.ToLower()}.";

            txtMessage.Text = message3;


            // string interpolation with verbatim symbol
            // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation#how-to-use-escape-sequences-in-an-interpolated-string
            var message4 = $@"Storing {txtName.Text}'s speeches in ""c:\users\{string.Join("", txtName.Text.Split(' ')).ToLower()}""";
            txtMessage.Text = message4;
        }
    }
}
