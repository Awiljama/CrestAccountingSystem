namespace CrestAccountingSystem
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.mainAccountNameLabel = new System.Windows.Forms.Label();
            this.accountEmailLabel = new System.Windows.Forms.Label();
            this.accountPhoneNUmberLabel = new System.Windows.Forms.Label();
            this.AccountNameTextBox = new System.Windows.Forms.TextBox();
            this.AccountContactNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New Account";
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.Location = new System.Drawing.Point(181, 167);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(96, 16);
            this.accountNameLabel.TabIndex = 2;
            this.accountNameLabel.Text = "Account Name";
            // 
            // mainAccountNameLabel
            // 
            this.mainAccountNameLabel.AutoSize = true;
            this.mainAccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAccountNameLabel.Location = new System.Drawing.Point(133, 208);
            this.mainAccountNameLabel.Name = "mainAccountNameLabel";
            this.mainAccountNameLabel.Size = new System.Drawing.Size(144, 16);
            this.mainAccountNameLabel.TabIndex = 3;
            this.mainAccountNameLabel.Text = "Account Contact Name";
            // 
            // accountEmailLabel
            // 
            this.accountEmailLabel.AutoSize = true;
            this.accountEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountEmailLabel.Location = new System.Drawing.Point(184, 290);
            this.accountEmailLabel.Name = "accountEmailLabel";
            this.accountEmailLabel.Size = new System.Drawing.Size(93, 16);
            this.accountEmailLabel.TabIndex = 4;
            this.accountEmailLabel.Text = "Account Email";
            // 
            // accountPhoneNUmberLabel
            // 
            this.accountPhoneNUmberLabel.AutoSize = true;
            this.accountPhoneNUmberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountPhoneNUmberLabel.Location = new System.Drawing.Point(128, 249);
            this.accountPhoneNUmberLabel.Name = "accountPhoneNUmberLabel";
            this.accountPhoneNUmberLabel.Size = new System.Drawing.Size(149, 16);
            this.accountPhoneNUmberLabel.TabIndex = 5;
            this.accountPhoneNUmberLabel.Text = "Account Phone Number";
            // 
            // AccountNameTextBox
            // 
            this.AccountNameTextBox.Location = new System.Drawing.Point(283, 167);
            this.AccountNameTextBox.Name = "AccountNameTextBox";
            this.AccountNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.AccountNameTextBox.TabIndex = 0;
            // 
            // AccountContactNameTextBox
            // 
            this.AccountContactNameTextBox.Location = new System.Drawing.Point(283, 208);
            this.AccountContactNameTextBox.Name = "AccountContactNameTextBox";
            this.AccountContactNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.AccountContactNameTextBox.TabIndex = 1;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(283, 249);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(172, 20);
            this.PhoneNumberTextBox.TabIndex = 2;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(283, 290);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(172, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(208, 353);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(159, 39);
            this.createAccountButton.TabIndex = 4;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(208, 396);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(159, 39);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset Form";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 518);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.AccountContactNameTextBox);
            this.Controls.Add(this.AccountNameTextBox);
            this.Controls.Add(this.accountPhoneNUmberLabel);
            this.Controls.Add(this.accountEmailLabel);
            this.Controls.Add(this.mainAccountNameLabel);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateAccount";
            this.Text = "Create New Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label mainAccountNameLabel;
        private System.Windows.Forms.Label accountEmailLabel;
        private System.Windows.Forms.Label accountPhoneNUmberLabel;
        private System.Windows.Forms.TextBox AccountNameTextBox;
        private System.Windows.Forms.TextBox AccountContactNameTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

