
namespace BankApp.UI
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AccountType = new System.Windows.Forms.GroupBox();
            this.current_radio = new System.Windows.Forms.RadioButton();
            this.savings_radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.initialDeposit = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.rpassword = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstnametextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.AccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 699);
            this.panel1.TabIndex = 0;
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginbtn.ForeColor = System.Drawing.Color.Red;
            this.loginbtn.Location = new System.Drawing.Point(43, 630);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(176, 59);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "Back";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AccountType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.initialDeposit);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.CreateAccount);
            this.panel2.Controls.Add(this.rpassword);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.lastname);
            this.panel2.Controls.Add(this.firstnametextbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FirstName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 699);
            this.panel2.TabIndex = 1;
            // 
            // AccountType
            // 
            this.AccountType.Controls.Add(this.current_radio);
            this.AccountType.Controls.Add(this.savings_radio);
            this.AccountType.Location = new System.Drawing.Point(67, 318);
            this.AccountType.Name = "AccountType";
            this.AccountType.Size = new System.Drawing.Size(437, 61);
            this.AccountType.TabIndex = 20;
            this.AccountType.TabStop = false;
            // 
            // current_radio
            // 
            this.current_radio.AutoSize = true;
            this.current_radio.Location = new System.Drawing.Point(223, 26);
            this.current_radio.Name = "current_radio";
            this.current_radio.Size = new System.Drawing.Size(95, 29);
            this.current_radio.TabIndex = 0;
            this.current_radio.TabStop = true;
            this.current_radio.Text = "Current";
            this.current_radio.UseVisualStyleBackColor = true;
            // 
            // savings_radio
            // 
            this.savings_radio.AutoSize = true;
            this.savings_radio.Location = new System.Drawing.Point(8, 26);
            this.savings_radio.Name = "savings_radio";
            this.savings_radio.Size = new System.Drawing.Size(98, 29);
            this.savings_radio.TabIndex = 0;
            this.savings_radio.TabStop = true;
            this.savings_radio.Text = "Savings";
            this.savings_radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "HSBC BANK";
            // 
            // initialDeposit
            // 
            this.initialDeposit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.initialDeposit.Location = new System.Drawing.Point(65, 423);
            this.initialDeposit.Name = "initialDeposit";
            this.initialDeposit.Size = new System.Drawing.Size(437, 37);
            this.initialDeposit.TabIndex = 12;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(67, 497);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(437, 37);
            this.password.TabIndex = 13;
            // 
            // CreateAccount
            // 
            this.CreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateAccount.ForeColor = System.Drawing.Color.Red;
            this.CreateAccount.Location = new System.Drawing.Point(164, 634);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(188, 52);
            this.CreateAccount.TabIndex = 18;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // rpassword
            // 
            this.rpassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rpassword.Location = new System.Drawing.Point(67, 573);
            this.rpassword.Name = "rpassword";
            this.rpassword.PasswordChar = '*';
            this.rpassword.Size = new System.Drawing.Size(437, 37);
            this.rpassword.TabIndex = 14;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(67, 235);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(435, 37);
            this.email.TabIndex = 15;
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastname.Location = new System.Drawing.Point(67, 161);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(437, 37);
            this.lastname.TabIndex = 16;
            // 
            // firstnametextbox
            // 
            this.firstnametextbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnametextbox.Location = new System.Drawing.Point(67, 87);
            this.firstnametextbox.Name = "firstnametextbox";
            this.firstnametextbox.Size = new System.Drawing.Size(437, 37);
            this.firstnametextbox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(67, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Repeat password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(65, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Initial Deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(67, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(65, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(65, 63);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(106, 25);
            this.FirstName.TabIndex = 11;
            this.FirstName.Text = "First Name";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 699);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.AccountType.ResumeLayout(false);
            this.AccountType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox AccountType;
        private System.Windows.Forms.RadioButton current;
        private System.Windows.Forms.RadioButton savings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initialDeposit;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.TextBox rpassword;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstnametextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.RadioButton current_radio;
        private System.Windows.Forms.RadioButton savings_radio;
    }
}