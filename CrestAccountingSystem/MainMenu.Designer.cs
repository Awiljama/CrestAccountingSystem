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
            this.CreateNewAccount.Click += new System.EventHandler(this.CreateNewAccount_Click);
            // 
            // ViewLedgerButton
            // 
            this.ViewLedgerButton.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.ViewLedgerButton.Location = new System.Drawing.Point(299, 390);
            this.ViewLedgerButton.Name = "ViewLedgerButton";
            this.ViewLedgerButton.Size = new System.Drawing.Size(287, 71);
            this.ViewLedgerButton.TabIndex = 2;
            this.ViewLedgerButton.Text = "View Ledger";
            this.ViewLedgerButton.UseVisualStyleBackColor = true;
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
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 548);
            this.Controls.Add(this.AccountsReceivableButton);
            this.Controls.Add(this.AccountsPayableButton);
            this.Controls.Add(this.SearchAccountButton);
            this.Controls.Add(this.ViewLedgerButton);
            this.Controls.Add(this.CreateNewAccount);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "Welcome to the Crest Technologies Accounting System";
            this.Load += new System.EventHandler(this.MainMenu_Load);
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
    }
}