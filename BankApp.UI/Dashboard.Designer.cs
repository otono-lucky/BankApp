
namespace BankApp.UI
{
    partial class Dashboard
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
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accholder = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabControl();
            this.deposittab = new System.Windows.Forms.TabPage();
            this.depositbtn = new System.Windows.Forms.Button();
            this.depositdesccription = new System.Windows.Forms.TextBox();
            this.depositamount = new System.Windows.Forms.TextBox();
            this.debositaccnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.withdrawtab = new System.Windows.Forms.TabPage();
            this.withdrawbtn = new System.Windows.Forms.Button();
            this.descwithdrawaltxt = new System.Windows.Forms.TextBox();
            this.amountwithdrawtxt = new System.Windows.Forms.TextBox();
            this.accnumberwithdrawtext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.balancetab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.transfertab = new System.Windows.Forms.TabPage();
            this.transferbtn = new System.Windows.Forms.Button();
            this.transferdestxt = new System.Windows.Forms.TextBox();
            this.transferbenacctxt = new System.Windows.Forms.TextBox();
            this.transferamounttxt = new System.Windows.Forms.TextBox();
            this.transferaccnumbertxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.statementtab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openacctab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.openaccbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentbtn = new System.Windows.Forms.RadioButton();
            this.savingsbtn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.deposittab.SuspendLayout();
            this.withdrawtab.SuspendLayout();
            this.balancetab.SuspendLayout();
            this.transfertab.SuspendLayout();
            this.statementtab.SuspendLayout();
            this.openacctab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.accholder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 60);
            this.panel1.TabIndex = 0;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutbtn.ForeColor = System.Drawing.Color.Red;
            this.logoutbtn.Location = new System.Drawing.Point(12, 6);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(112, 51);
            this.logoutbtn.TabIndex = 2;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(482, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "AccountNumber";
            // 
            // accholder
            // 
            this.accholder.AutoSize = true;
            this.accholder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accholder.Location = new System.Drawing.Point(228, 22);
            this.accholder.Name = "accholder";
            this.accholder.Size = new System.Drawing.Size(64, 28);
            this.accholder.TabIndex = 0;
            this.accholder.Text = "Name";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.deposittab);
            this.tab2.Controls.Add(this.withdrawtab);
            this.tab2.Controls.Add(this.balancetab);
            this.tab2.Controls.Add(this.transfertab);
            this.tab2.Controls.Add(this.statementtab);
            this.tab2.Controls.Add(this.openacctab);
            this.tab2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tab2.Location = new System.Drawing.Point(0, 60);
            this.tab2.Name = "tab2";
            this.tab2.SelectedIndex = 0;
            this.tab2.Size = new System.Drawing.Size(731, 652);
            this.tab2.TabIndex = 1;
            // 
            // deposittab
            // 
            this.deposittab.Controls.Add(this.depositbtn);
            this.deposittab.Controls.Add(this.depositdesccription);
            this.deposittab.Controls.Add(this.depositamount);
            this.deposittab.Controls.Add(this.debositaccnumber);
            this.deposittab.Controls.Add(this.label4);
            this.deposittab.Controls.Add(this.label3);
            this.deposittab.Controls.Add(this.label1);
            this.deposittab.Controls.Add(this.flowLayoutPanel1);
            this.deposittab.Location = new System.Drawing.Point(4, 37);
            this.deposittab.Name = "deposittab";
            this.deposittab.Padding = new System.Windows.Forms.Padding(3);
            this.deposittab.Size = new System.Drawing.Size(723, 611);
            this.deposittab.TabIndex = 0;
            this.deposittab.Text = "Deposit";
            this.deposittab.UseVisualStyleBackColor = true;
            // 
            // depositbtn
            // 
            this.depositbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositbtn.ForeColor = System.Drawing.Color.Red;
            this.depositbtn.Location = new System.Drawing.Point(291, 504);
            this.depositbtn.Name = "depositbtn";
            this.depositbtn.Size = new System.Drawing.Size(152, 47);
            this.depositbtn.TabIndex = 7;
            this.depositbtn.Text = "Deposit";
            this.depositbtn.UseVisualStyleBackColor = true;
            this.depositbtn.Click += new System.EventHandler(this.depositbtn_Click);
            // 
            // depositdesccription
            // 
            this.depositdesccription.Location = new System.Drawing.Point(242, 423);
            this.depositdesccription.Multiline = true;
            this.depositdesccription.Name = "depositdesccription";
            this.depositdesccription.Size = new System.Drawing.Size(317, 46);
            this.depositdesccription.TabIndex = 6;
            // 
            // depositamount
            // 
            this.depositamount.Location = new System.Drawing.Point(242, 353);
            this.depositamount.Multiline = true;
            this.depositamount.Name = "depositamount";
            this.depositamount.Size = new System.Drawing.Size(324, 41);
            this.depositamount.TabIndex = 5;
            // 
            // debositaccnumber
            // 
            this.debositaccnumber.Location = new System.Drawing.Point(242, 259);
            this.debositaccnumber.Multiline = true;
            this.debositaccnumber.Name = "debositaccnumber";
            this.debositaccnumber.Size = new System.Drawing.Size(317, 41);
            this.debositaccnumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(94, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::BankApp.UI.Properties.Resources.hsbcbank1;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(717, 199);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // withdrawtab
            // 
            this.withdrawtab.Controls.Add(this.withdrawbtn);
            this.withdrawtab.Controls.Add(this.descwithdrawaltxt);
            this.withdrawtab.Controls.Add(this.amountwithdrawtxt);
            this.withdrawtab.Controls.Add(this.accnumberwithdrawtext);
            this.withdrawtab.Controls.Add(this.label7);
            this.withdrawtab.Controls.Add(this.label6);
            this.withdrawtab.Controls.Add(this.label5);
            this.withdrawtab.Controls.Add(this.panel2);
            this.withdrawtab.Location = new System.Drawing.Point(4, 37);
            this.withdrawtab.Name = "withdrawtab";
            this.withdrawtab.Padding = new System.Windows.Forms.Padding(3);
            this.withdrawtab.Size = new System.Drawing.Size(703, 611);
            this.withdrawtab.TabIndex = 1;
            this.withdrawtab.Text = "Withdraw";
            this.withdrawtab.UseVisualStyleBackColor = true;
            // 
            // withdrawbtn
            // 
            this.withdrawbtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawbtn.ForeColor = System.Drawing.Color.Red;
            this.withdrawbtn.Location = new System.Drawing.Point(308, 488);
            this.withdrawbtn.Name = "withdrawbtn";
            this.withdrawbtn.Size = new System.Drawing.Size(175, 55);
            this.withdrawbtn.TabIndex = 7;
            this.withdrawbtn.Text = "Withdraw";
            this.withdrawbtn.UseVisualStyleBackColor = true;
            // 
            // descwithdrawaltxt
            // 
            this.descwithdrawaltxt.Location = new System.Drawing.Point(256, 413);
            this.descwithdrawaltxt.Multiline = true;
            this.descwithdrawaltxt.Name = "descwithdrawaltxt";
            this.descwithdrawaltxt.Size = new System.Drawing.Size(326, 46);
            this.descwithdrawaltxt.TabIndex = 6;
            // 
            // amountwithdrawtxt
            // 
            this.amountwithdrawtxt.Location = new System.Drawing.Point(256, 332);
            this.amountwithdrawtxt.Multiline = true;
            this.amountwithdrawtxt.Name = "amountwithdrawtxt";
            this.amountwithdrawtxt.Size = new System.Drawing.Size(326, 46);
            this.amountwithdrawtxt.TabIndex = 5;
            // 
            // accnumberwithdrawtext
            // 
            this.accnumberwithdrawtext.Location = new System.Drawing.Point(256, 251);
            this.accnumberwithdrawtext.Multiline = true;
            this.accnumberwithdrawtext.Name = "accnumberwithdrawtext";
            this.accnumberwithdrawtext.Size = new System.Drawing.Size(326, 46);
            this.accnumberwithdrawtext.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(83, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Description";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(92, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BankApp.UI.Properties.Resources.hsbcbank1;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 186);
            this.panel2.TabIndex = 0;
            // 
            // balancetab
            // 
            this.balancetab.Controls.Add(this.label9);
            this.balancetab.Controls.Add(this.label8);
            this.balancetab.Controls.Add(this.panel3);
            this.balancetab.Location = new System.Drawing.Point(4, 37);
            this.balancetab.Name = "balancetab";
            this.balancetab.Padding = new System.Windows.Forms.Padding(3);
            this.balancetab.Size = new System.Drawing.Size(703, 611);
            this.balancetab.TabIndex = 2;
            this.balancetab.Text = "Check Balance";
            this.balancetab.UseVisualStyleBackColor = true;
            this.balancetab.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(259, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 38);
            this.label9.TabIndex = 2;
            this.label9.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(215, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 38);
            this.label8.TabIndex = 1;
            this.label8.Text = "Account Number";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::BankApp.UI.Properties.Resources.hsbcbank1;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 198);
            this.panel3.TabIndex = 0;
            // 
            // transfertab
            // 
            this.transfertab.Controls.Add(this.transferbtn);
            this.transfertab.Controls.Add(this.transferdestxt);
            this.transfertab.Controls.Add(this.transferbenacctxt);
            this.transfertab.Controls.Add(this.transferamounttxt);
            this.transfertab.Controls.Add(this.transferaccnumbertxt);
            this.transfertab.Controls.Add(this.label13);
            this.transfertab.Controls.Add(this.label12);
            this.transfertab.Controls.Add(this.label11);
            this.transfertab.Controls.Add(this.panel4);
            this.transfertab.Controls.Add(this.label10);
            this.transfertab.Location = new System.Drawing.Point(4, 37);
            this.transfertab.Name = "transfertab";
            this.transfertab.Padding = new System.Windows.Forms.Padding(3);
            this.transfertab.Size = new System.Drawing.Size(703, 611);
            this.transfertab.TabIndex = 3;
            this.transfertab.Text = "Transfer";
            this.transfertab.UseVisualStyleBackColor = true;
            // 
            // transferbtn
            // 
            this.transferbtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transferbtn.ForeColor = System.Drawing.Color.Red;
            this.transferbtn.Location = new System.Drawing.Point(322, 510);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(175, 53);
            this.transferbtn.TabIndex = 9;
            this.transferbtn.Text = "Transfer";
            this.transferbtn.UseVisualStyleBackColor = true;
            // 
            // transferdestxt
            // 
            this.transferdestxt.Location = new System.Drawing.Point(253, 446);
            this.transferdestxt.Multiline = true;
            this.transferdestxt.Name = "transferdestxt";
            this.transferdestxt.Size = new System.Drawing.Size(347, 46);
            this.transferdestxt.TabIndex = 8;
            // 
            // transferbenacctxt
            // 
            this.transferbenacctxt.Location = new System.Drawing.Point(253, 377);
            this.transferbenacctxt.Multiline = true;
            this.transferbenacctxt.Name = "transferbenacctxt";
            this.transferbenacctxt.Size = new System.Drawing.Size(347, 46);
            this.transferbenacctxt.TabIndex = 7;
            // 
            // transferamounttxt
            // 
            this.transferamounttxt.Location = new System.Drawing.Point(253, 304);
            this.transferamounttxt.Multiline = true;
            this.transferamounttxt.Name = "transferamounttxt";
            this.transferamounttxt.Size = new System.Drawing.Size(347, 46);
            this.transferamounttxt.TabIndex = 6;
            // 
            // transferaccnumbertxt
            // 
            this.transferaccnumbertxt.Location = new System.Drawing.Point(253, 237);
            this.transferaccnumbertxt.Multiline = true;
            this.transferaccnumbertxt.Name = "transferaccnumbertxt";
            this.transferaccnumbertxt.Size = new System.Drawing.Size(347, 47);
            this.transferaccnumbertxt.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(85, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 28);
            this.label13.TabIndex = 4;
            this.label13.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 28);
            this.label12.TabIndex = 3;
            this.label12.Text = "Beneficiary Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 28);
            this.label11.TabIndex = 2;
            this.label11.Text = "Account Number";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::BankApp.UI.Properties.Resources.hsbcbank1;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(697, 188);
            this.panel4.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Amount";
            // 
            // statementtab
            // 
            this.statementtab.Controls.Add(this.richTextBox1);
            this.statementtab.Location = new System.Drawing.Point(4, 37);
            this.statementtab.Name = "statementtab";
            this.statementtab.Padding = new System.Windows.Forms.Padding(3);
            this.statementtab.Size = new System.Drawing.Size(703, 611);
            this.statementtab.TabIndex = 4;
            this.statementtab.Text = "Account Statement";
            this.statementtab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(645, 463);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openacctab
            // 
            this.openacctab.Controls.Add(this.panel5);
            this.openacctab.Controls.Add(this.openaccbtn);
            this.openacctab.Controls.Add(this.groupBox1);
            this.openacctab.Location = new System.Drawing.Point(4, 37);
            this.openacctab.Name = "openacctab";
            this.openacctab.Padding = new System.Windows.Forms.Padding(3);
            this.openacctab.Size = new System.Drawing.Size(703, 611);
            this.openacctab.TabIndex = 5;
            this.openacctab.Text = "Open Account";
            this.openacctab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::BankApp.UI.Properties.Resources.hsbcbank1;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(697, 191);
            this.panel5.TabIndex = 3;
            // 
            // openaccbtn
            // 
            this.openaccbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openaccbtn.ForeColor = System.Drawing.Color.Red;
            this.openaccbtn.Location = new System.Drawing.Point(238, 427);
            this.openaccbtn.Name = "openaccbtn";
            this.openaccbtn.Size = new System.Drawing.Size(179, 59);
            this.openaccbtn.TabIndex = 2;
            this.openaccbtn.Text = "Submit";
            this.openaccbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentbtn);
            this.groupBox1.Controls.Add(this.savingsbtn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(120, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Account  type";
            // 
            // currentbtn
            // 
            this.currentbtn.AutoSize = true;
            this.currentbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentbtn.Location = new System.Drawing.Point(270, 61);
            this.currentbtn.Name = "currentbtn";
            this.currentbtn.Size = new System.Drawing.Size(119, 36);
            this.currentbtn.TabIndex = 1;
            this.currentbtn.TabStop = true;
            this.currentbtn.Text = "Current";
            this.currentbtn.UseVisualStyleBackColor = true;
            // 
            // savingsbtn
            // 
            this.savingsbtn.AutoSize = true;
            this.savingsbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savingsbtn.Location = new System.Drawing.Point(34, 61);
            this.savingsbtn.Name = "savingsbtn";
            this.savingsbtn.Size = new System.Drawing.Size(120, 36);
            this.savingsbtn.TabIndex = 0;
            this.savingsbtn.TabStop = true;
            this.savingsbtn.Text = "Savings";
            this.savingsbtn.UseVisualStyleBackColor = true;
            this.savingsbtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 676);
            this.Controls.Add(this.tab2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "HSBC BANK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.deposittab.ResumeLayout(false);
            this.deposittab.PerformLayout();
            this.withdrawtab.ResumeLayout(false);
            this.withdrawtab.PerformLayout();
            this.balancetab.ResumeLayout(false);
            this.balancetab.PerformLayout();
            this.transfertab.ResumeLayout(false);
            this.transfertab.PerformLayout();
            this.statementtab.ResumeLayout(false);
            this.openacctab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accholder;
        private System.Windows.Forms.TabControl tab2;
        private System.Windows.Forms.TabPage deposittab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox debositaccnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage withdrawtab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage balancetab;
        private System.Windows.Forms.TabPage transfertab;
        private System.Windows.Forms.TabPage statementtab;
        private System.Windows.Forms.TabPage openacctab;
        private System.Windows.Forms.Button depositbtn;
        private System.Windows.Forms.TextBox depositdesccription;
        private System.Windows.Forms.TextBox depositamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accnumberwithdrawtext;
        private System.Windows.Forms.TextBox descwithdrawaltxt;
        private System.Windows.Forms.TextBox amountwithdrawtxt;
        private System.Windows.Forms.Button withdrawbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox transferdestxt;
        private System.Windows.Forms.TextBox transferbenacctxt;
        private System.Windows.Forms.TextBox transferamounttxt;
        private System.Windows.Forms.TextBox transferaccnumbertxt;
        private System.Windows.Forms.Button transferbtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton currentbtn;
        private System.Windows.Forms.RadioButton savingsbtn;
        private System.Windows.Forms.Button openaccbtn;
        private System.Windows.Forms.Panel panel5;
    }
}