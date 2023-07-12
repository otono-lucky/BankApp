
namespace BankApp.UI
{
    partial class Login
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
            this.createacc = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.loginpassword = new System.Windows.Forms.TextBox();
            this.loginemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 150);
            this.panel1.TabIndex = 0;
            // 
            // createacc
            // 
            this.createacc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createacc.ForeColor = System.Drawing.Color.Red;
            this.createacc.Location = new System.Drawing.Point(237, 474);
            this.createacc.Name = "createacc";
            this.createacc.Size = new System.Drawing.Size(214, 54);
            this.createacc.TabIndex = 11;
            this.createacc.Text = "Create Account";
            this.createacc.UseVisualStyleBackColor = true;
            this.createacc.Click += new System.EventHandler(this.createacc_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginbtn.ForeColor = System.Drawing.Color.Red;
            this.loginbtn.Location = new System.Drawing.Point(276, 374);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(133, 57);
            this.loginbtn.TabIndex = 10;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // loginpassword
            // 
            this.loginpassword.Location = new System.Drawing.Point(193, 296);
            this.loginpassword.Multiline = true;
            this.loginpassword.Name = "loginpassword";
            this.loginpassword.PasswordChar = '*';
            this.loginpassword.Size = new System.Drawing.Size(359, 46);
            this.loginpassword.TabIndex = 9;
            // 
            // loginemail
            // 
            this.loginemail.Location = new System.Drawing.Point(193, 193);
            this.loginemail.Multiline = true;
            this.loginemail.Name = "loginemail";
            this.loginemail.Size = new System.Drawing.Size(359, 46);
            this.loginemail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 615);
            this.Controls.Add(this.createacc);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.loginpassword);
            this.Controls.Add(this.loginemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createacc;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox loginpassword;
        private System.Windows.Forms.TextBox loginemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}