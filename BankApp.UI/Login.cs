using BankApp.Core.IService;
using System;
using System.Windows.Forms;

namespace BankApp.UI
{
    public partial class Login : Form
    {
        public static string _email;
        private readonly ICustomerService _cust;
        private readonly IAccountService _accRepo;
        private readonly ITransactionService _transRepo;
        public Login(ICustomerService customerRepositories, IAccountService accountRepositories, ITransactionService transaction)
        {
            InitializeComponent();
            _cust = customerRepositories;
            _accRepo = accountRepositories;
            _transRepo = transaction;
        }
        private void createacc_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(Registration registration = new Registration(_cust, _accRepo, _transRepo))
            {
                registration.ShowDialog();
            }
           // Registration.Show();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string email = loginemail.Text;
            string password = loginpassword.Text;
            var emailAndPasswordIsValid = _cust.Login(email, password);

            if (emailAndPasswordIsValid)
            {
                _email = email;
                this.Hide();
                new Dashboard(_cust, _accRepo, _transRepo).Show();
            }
            else
            {
                MessageBox.Show("Invalid Credendtials");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
