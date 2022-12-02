namespace Remozo_Application
{
    partial class create_account
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_createAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remozo_Application.Properties.Resources.App___Account_Creation_Blank;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 1141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(79, 203);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(359, 23);
            this.txt_login.TabIndex = 1;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(79, 291);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(359, 23);
            this.txt_phoneNumber.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(79, 379);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(359, 23);
            this.txt_password.TabIndex = 3;
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Location = new System.Drawing.Point(79, 469);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PasswordChar = '*';
            this.txt_confirmPassword.Size = new System.Drawing.Size(359, 23);
            this.txt_confirmPassword.TabIndex = 4;
            this.txt_confirmPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 553);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.BackColor = System.Drawing.Color.Red;
            this.btn_createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createAccount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_createAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_createAccount.Location = new System.Drawing.Point(92, 619);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(346, 84);
            this.btn_createAccount.TabIndex = 6;
            this.btn_createAccount.Text = "Create Account";
            this.btn_createAccount.UseVisualStyleBackColor = false;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // create_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 1102);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(538, 1141);
            this.MinimumSize = new System.Drawing.Size(538, 1141);
            this.Name = "create_account";
            this.Text = "Remozo - Create Account";
            this.Load += new System.EventHandler(this.create_account_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_login;
        private TextBox txt_phoneNumber;
        private TextBox txt_password;
        private TextBox txt_confirmPassword;
        private ComboBox comboBox1;
        private Button btn_createAccount;
    }
}