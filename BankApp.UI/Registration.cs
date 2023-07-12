using BankApp.Commons;
using BankApp.Core.IService;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BankApp.UI
{
    public partial class Registration : Form
    {
        //private readonly CustomerService _customer;
        private string _firstName, _lastName, _email, _password, conf_pass;
        private ICustomerService _customer;
        private IAccountService _accService;
        private readonly ITransactionService _transaction;

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login(_customer, _accService, _transaction)).Show();
        }

        public Registration(ICustomerService customer, IAccountService accountService, ITransactionService transaction)
        {
            InitializeComponent();
            _customer = customer;
            _accService = accountService;
            _transaction = transaction;
            //this._customer = (CustomerService)customer;
        }
        private void CreateAccount_Click(object sender, EventArgs e)
        {
            _firstName = Validation.Capitalize(Validation.RemoveDigit(firstnametextbox.Text));
            _lastName = Validation.Capitalize(Validation.RemoveDigit(lastname.Text));
            if (!Validation.EmailValidation(email.Text))
            {
                MessageBox.Show("Invalid email");
                return;
            }
            _email = email.Text;
            _password = password.Text;
            conf_pass = rpassword.Text;
            {
                if (this.CheckPassword(_password, conf_pass))
                {
                    string accType = "";
                    bool isChecked = savings_radio.Checked;
                    if (isChecked)
                        accType = savings_radio.Text.ToLower();
                    else
                        accType = current_radio.Text.ToLower();

                    var amount = Convert.ToDecimal(initialDeposit.Text);

                    var cusomer = _customer.Create(firstnametextbox.Text, lastname.Text, _email, _password, amount, accType);

                    MessageBox.Show("Account Created Successfully");
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                    return;
                }

            }
            this.Hide();
            using (Dashboard dashboard = new Dashboard(_customer, _accService, _transaction))
            {
                dashboard.ShowDialog();
            }
        }
        private void Registration_Load(object sender, EventArgs e)
        {

        }
        public bool CheckPassword(string pass1, string pass2)
        {
            if (pass1.Equals(pass2))
                return true;
            return false;
        }
    }
}
