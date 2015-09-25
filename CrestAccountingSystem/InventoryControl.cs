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
    public partial class InventoryControl : Form
    {
        public MainMenu MainMenu { get; set; }
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveChanges()
        {

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            var saveChanges = MessageBox.Show("Update Changes To Inventory?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
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
