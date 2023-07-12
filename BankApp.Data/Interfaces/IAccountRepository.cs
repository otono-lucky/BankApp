using BankApp.Models;

namespace BankApp.Data.Interfaces
{
    interface IAccountRepository
    {
        public bool CreateAccount(Account account);
        public Account GetAccount(string AccountNumber);
        public bool Deposit(string account, decimal amount);
        public bool Withdrawal(string accountNumber, decimal amount);
        public bool Transfer(string accountNumber, string beneficiaryAccNumber, decimal amount, string description);
        public decimal GetAccountBalane(string account);
        bool Exist(string accnumber);
    }
}
