using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Mail;
using System.Drawing;

namespace CrestAccountingSystem
{
    public partial class CreateAccount : Form
    {
        private List<TextBox> Fields;
        const string EMAIL_MESSAGE = "Please enter a valid email address";
        const string EMAIL_CAPTION = "INVALID EMAIL";
        const string FIELD_VALIDATION_MESSAGE = "All fields must be completed";
        const string FIELD_VALIDATION_CAPTION = "INFORMATION REQUIRED";
        const string PHONE_MESSAGE = "Please enter a valid phone number";
        const string PHONE_CAPTION = "INVALID PHONE NUMBER";
		const int MAX_PHONE_VALUE = 9999;
        const string PHONE_NUMBER_FORMAT_PLACEHOLDER = "xxx-xxx-xxxx";
        public MainMenu MainMenu { get; set; }

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            Fields = new List<TextBox> { EmailTextBox, PhoneNumberTextBox, AccountNameTextBox, AccountContactNameTextBox };
            FormatPhoneNumberTextBox();
        }

        private void FormatPhoneNumberTextBox()
        {
            PhoneNumberTextBox.Text = PHONE_NUMBER_FORMAT_PLACEHOLDER;
            PhoneNumberTextBox.ForeColor = Color.Gray;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                ParseFields();
                CheckForValidEmail();
                CheckForValidPhoneNumber();
				var accountContact = new AccountContact(AccountNameTextBox.Text, AccountContactNameTextBox.Text, 
                                                 PhoneNumberTextBox.Text, EmailTextBox.Text);
                var account = new Account(accountContact);
            }
            catch (FormatException) // we catch this exception so that we can take advantage of MailAddress throwing an exception
            {
                DisplayMessageBox(EMAIL_MESSAGE, EMAIL_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                DisplayMessageBox(FIELD_VALIDATION_MESSAGE, FIELD_VALIDATION_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParseFields()
        {
            foreach (var field in Fields)
            {
                if (string.IsNullOrEmpty(field.Text))
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
            foreach (var digitGroup in digits)
            {
                bool success = int.TryParse(digitGroup, out number);
                if (!success || number > MAX_PHONE_VALUE)
                {
                    DisplayMessageBox(PHONE_MESSAGE, PHONE_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayMessageBox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, buttons, icon);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (var field in Fields)
            {
                field.Text = string.Empty;
                AccountNameTextBox.Focus();
            }
            FormatPhoneNumberTextBox();
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PhoneNumberTextBox.ForeColor = Color.Black;
        }

        private void PhoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (PhoneNumberTextBox.Text == PHONE_NUMBER_FORMAT_PLACEHOLDER)
            {
                PhoneNumberTextBox.Text = string.Empty;
            }
        }

        private void PhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (PhoneNumberTextBox.Text == PHONE_NUMBER_FORMAT_PLACEHOLDER || PhoneNumberTextBox.Text == string.Empty)
            {
                FormatPhoneNumberTextBox();
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            Hide();
        }
    }
}
