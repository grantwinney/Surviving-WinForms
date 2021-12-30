using NLog;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NameOfVersusMagicStrings
{
    public partial class Form1 : Form
    {
        private readonly Logger logger;

        public Form1()
        {
            InitializeComponent();
            logger = LogManager.GetLogger("");
            txtUserId.Focus();
        }

        // Using nameof inside properties

        public string UserId
        {
            get => txtUserId.Text;
            set => txtUserId.Text = int.TryParse(value, out int userId) && userId > 0
                       ? value
                       : throw new ArgumentOutOfRangeException(nameof(value), $"The {nameof(UserId)} must be a positive number.");
        }

        public string Username
        {
            get => txtUsername.Text;
        }

        // Using nameof inside logging

        private void btnSave_Click(object sender, EventArgs e)
        {
            logger.Trace($"Entering {nameof(btnSave_Click)} event.");

            try
            {
                logger.Trace($"Attempting to save username in {nameof(btnSave_Click)} event.");

                var db = new DatabaseLayer();
                db.SaveUsername(UserId, Username);

                logger.Trace($"Save succeeded in {nameof(btnSave_Click)} event.");
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Save failed in {nameof(btnSave_Click)} event.");
                MessageBox.Show("Save failed. :(");
            }
            finally
            {
                logger.Trace($"Exiting {nameof(btnSave_Click)} event.");
            }
        }

        private void txtUserId_Validating(object sender, CancelEventArgs e)
        {
            if (UserId == "")
                errorProvider1.SetError(txtUserId, $"{nameof(UserId)} cannot be empty");
            else if (!int.TryParse(txtUserId.Text, out int userId) || userId < 1)
                errorProvider1.SetError(txtUserId, $"{nameof(UserId)} must be a positive number");
            else
                errorProvider1.SetError(txtUserId, "");
        }

        private void btnSetUserId_Click(object sender, EventArgs e)
        {
            try
            {
                UserId = "-3";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
