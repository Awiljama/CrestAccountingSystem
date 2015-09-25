using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrestAccountingSystem
{
    public partial class AccountsPayable : Form
    {
        public MainMenu MainMenu { get; set; }
        public AccountsPayable()
        {
            InitializeComponent();
        }

        private void SaveChanges()
        { }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            var saveChanges = MessageBox.Show("Update Accounts Payable Information?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (saveChanges)
            {
                case DialogResult.Yes:
                    SaveChanges();
                    MainMenu.Show();
                    Close();
                    break;
                case DialogResult.No:
                    MainMenu.Show();
                    Close();
                    break;
                case DialogResult.Cancel:
                    return;
            }
        }
    }
}
