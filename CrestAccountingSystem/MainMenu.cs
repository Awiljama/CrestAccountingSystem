using System;
using System.Windows.Forms;

namespace CrestAccountingSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void createNewAccount_Click(object sender, EventArgs e)
        {
            var createAccount = new CreateAccount();
            createAccount.MainMenu = this;
            createAccount.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout?", "Logout of Acconting System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void viewLedgerButton_Click(object sender, EventArgs e)
        {
            var ledger = new Ledger();
            ledger.MainMenu = this;
            ledger.Show();
        }

        private void accountsPayableButton_Click(object sender, EventArgs e)
        {
            var accountsPayable = new AccountsPayable();
            accountsPayable.MainMenu = this;
            accountsPayable.Show();
        }

        private void accountsReceivableButton_Click(object sender, EventArgs e)
        {
            var accountsReceivable = new AccountsReceivable();
            accountsReceivable.MainMenu = this;
            accountsReceivable.Show();
        }

        private void generalJournalButton_Click(object sender, EventArgs e)
        {
            var generalJournal = new GeneralJournal();
            generalJournal.MainMenu = this;
            generalJournal.Show();
        }

        private void inventoryControlButton_Click(object sender, EventArgs e)
        {
            var inventoryControl = new InventoryControl();
            inventoryControl.MainMenu = this;
            inventoryControl.Show();
        }
    }
}
