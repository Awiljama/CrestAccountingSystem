using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Mail;

namespace CrestAccountingSystem
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                ParseFields();
                CheckForValidEmail();
                CheckForValidPhoneNumber();
            }
            catch (FormatException) // we catch this exception so that we can take advantage of MailAddress throwing an exception
            {
                DisplayMessageBox("Please enter a valid email address", "INVALID EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                DisplayMessageBox("All fields must be completed", "INFORMATION REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParseFields()
        {
            var fields = new List<TextBox> { AccountContactNameTextBox, AccountNameTextBox, PhoneNumberTextBox, EmailTextBox };
            foreach (var Field in fields)
            {
                if (string.IsNullOrEmpty(Field.Text))
                {
                    throw new Exception();
                }
            }
        }

        private void CheckForValidEmail()
        {
            var validEmail = new MailAddress(EmailTextBox.Text);
        }

        private void CheckForValidPhoneNumber()
        {
            string[] digits;
            var phoneNumberSeparators = new string[] { "-", "." };
            digits = PhoneNumberTextBox.Text.Split(phoneNumberSeparators, 3, StringSplitOptions.RemoveEmptyEntries);
            int number;
            foreach (var digitSection in digits)
            {
                bool result = Int32.TryParse(digitSection, out number);
                if (!result)
                {
                    DisplayMessageBox("Please enter a valid phone number", "INVALID PHONE NUMBER", MessageBoxButtons.OK, 
                                      MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayMessageBox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, buttons, icon);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            var fields = new List<TextBox> { AccountContactNameTextBox, AccountNameTextBox, PhoneNumberTextBox, EmailTextBox };
            foreach (var Field in fields)
            {
                Field.Text = string.Empty;
                AccountNameTextBox.Focus();
            }
        }
    }
}
