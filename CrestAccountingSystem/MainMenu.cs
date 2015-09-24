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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewAccount_Click(object sender, EventArgs e)
        {
            var createAccount = new CreateAccount();
            createAccount.Show();
        }
    }
}
