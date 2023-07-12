using BankApp.Models;

namespace BankApp.Core.IService
{
    public interface IAccountService
    {
        public void CreateAccount(string AccType, decimal initialDeposit, int customerId);

        public bool Deposit(string accnumber, decimal amount, string note = "Deposit");

        public string Withdraw(string accnumber, decimal amount, string note = "Withdrawal");

        public bool Transfer(string accnumber, string beneficiaryacc, decimal amount, string note);
        public Account GetAccount(string AccountNumber);
    }
}
