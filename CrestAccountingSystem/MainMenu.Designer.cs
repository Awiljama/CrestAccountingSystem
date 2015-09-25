namespace CrestAccountingSystem
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateNewAccount = new System.Windows.Forms.Button();
            this.ViewLedgerButton = new System.Windows.Forms.Button();
            this.SearchAccountButton = new System.Windows.Forms.Button();
            this.AccountsPayableButton = new System.Windows.Forms.Button();
            this.AccountsReceivableButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.GeneralJournalButton = new System.Windows.Forms.Button();
            this.InventoryControlButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CreateNewAccount
            // 
            this.CreateNewAccount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewAccount.Location = new System.Drawing.Point(299, 180);
            this.CreateNewAccount.Name = "CreateNewAccount";
            this.CreateNewAccount.Size = new System.Drawing.Size(287, 71);
            this.CreateNewAccount.TabIndex = 1;
            this.CreateNewAccount.Text = "Create New Account";
            this.CreateNewAccount.UseVisualStyleBackColor = true;
            this.CreateNewAccount.Click += new System.EventHandler(this.createNewAccount_Click);
            // 
            // ViewLedgerButton
            // 
            this.ViewLedgerButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLedgerButton.Location = new System.Drawing.Point(12, 379);
            this.ViewLedgerButton.Name = "ViewLedgerButton";
            this.ViewLedgerButton.Size = new System.Drawing.Size(287, 71);
            this.ViewLedgerButton.TabIndex = 2;
            this.ViewLedgerButton.Text = "Ledger";
            this.ViewLedgerButton.UseVisualStyleBackColor = true;
            this.ViewLedgerButton.Click += new System.EventHandler(this.viewLedgerButton_Click);
            // 
            // SearchAccountButton
            // 
            this.SearchAccountButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAccountButton.Location = new System.Drawing.Point(12, 285);
            this.SearchAccountButton.Name = "SearchAccountButton";
            this.SearchAccountButton.Size = new System.Drawing.Size(287, 71);
            this.SearchAccountButton.TabIndex = 3;
            this.SearchAccountButton.Text = "Search Accounts";
            this.SearchAccountButton.UseVisualStyleBackColor = true;
            // 
            // AccountsPayableButton
            // 
            this.AccountsPayableButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsPayableButton.Location = new System.Drawing.Point(299, 285);
            this.AccountsPayableButton.Name = "AccountsPayableButton";
            this.AccountsPayableButton.Size = new System.Drawing.Size(287, 71);
            this.AccountsPayableButton.TabIndex = 4;
            this.AccountsPayableButton.Text = "Accounts Payable";
            this.AccountsPayableButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AccountsPayableButton.UseVisualStyleBackColor = true;
            this.AccountsPayableButton.Click += new System.EventHandler(this.accountsPayableButton_Click);
            // 
            // AccountsReceivableButton
            // 
            this.AccountsReceivableButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsReceivableButton.Location = new System.Drawing.Point(586, 285);
            this.AccountsReceivableButton.Name = "AccountsReceivableButton";
            this.AccountsReceivableButton.Size = new System.Drawing.Size(287, 71);
            this.AccountsReceivableButton.TabIndex = 5;
            this.AccountsReceivableButton.Text = "Accounts Receivable";
            this.AccountsReceivableButton.UseVisualStyleBackColor = true;
            this.AccountsReceivableButton.Click += new System.EventHandler(this.accountsReceivableButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(798, 513);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // GeneralJournalButton
            // 
            this.GeneralJournalButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralJournalButton.Location = new System.Drawing.Point(299, 379);
            this.GeneralJournalButton.Name = "GeneralJournalButton";
            this.GeneralJournalButton.Size = new System.Drawing.Size(287, 71);
            this.GeneralJournalButton.TabIndex = 7;
            this.GeneralJournalButton.Text = "General Journal";
            this.GeneralJournalButton.UseVisualStyleBackColor = true;
            this.GeneralJournalButton.Click += new System.EventHandler(this.generalJournalButton_Click);
            // 
            // InventoryControlButton
            // 
            this.InventoryControlButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryControlButton.Location = new System.Drawing.Point(586, 378);
            this.InventoryControlButton.Name = "InventoryControlButton";
            this.InventoryControlButton.Size = new System.Drawing.Size(287, 72);
            this.InventoryControlButton.TabIndex = 8;
            this.InventoryControlButton.Text = "Inventory Control";
            this.InventoryControlButton.UseVisualStyleBackColor = true;
            this.InventoryControlButton.Click += new System.EventHandler(this.inventoryControlButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 548);
            this.Controls.Add(this.InventoryControlButton);
            this.Controls.Add(this.GeneralJournalButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.AccountsReceivableButton);
            this.Controls.Add(this.AccountsPayableButton);
            this.Controls.Add(this.SearchAccountButton);
            this.Controls.Add(this.ViewLedgerButton);
            this.Controls.Add(this.CreateNewAccount);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "Welcome to the Crest Technologies Accounting System";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CreateNewAccount;
        private System.Windows.Forms.Button ViewLedgerButton;
        private System.Windows.Forms.Button SearchAccountButton;
        private System.Windows.Forms.Button AccountsPayableButton;
        private System.Windows.Forms.Button AccountsReceivableButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button GeneralJournalButton;
        private System.Windows.Forms.Button InventoryControlButton;
    }
}