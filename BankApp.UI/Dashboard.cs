using BankApp.Core.IService;
using System;
using System.Windows.Forms;

namespace BankApp.UI
{
    public partial class Dashboard : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IAccountService _accountService;
        private readonly ITransactionService _transactionService;
        public Dashboard(ICustomerService customerService, IAccountService accountService, ITransactionService transactionService)
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void depositbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
