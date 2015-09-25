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
    partial class AccountsReceivablePayable : Form
    {
        public MainMenu MainMenu { get; set; }
        protected AccountsReceivablePayable()
        {
            InitializeComponent();
        }

        private void SaveChanges()
        {

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            var saveChangesOnExit = MessageBox.Show("Save Changes Before Exiting?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (saveChangesOnExit)
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
