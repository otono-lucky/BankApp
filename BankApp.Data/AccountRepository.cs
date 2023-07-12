using BankApp.Data.Interfaces;
using BankApp.Models;
using System;
using System.Linq;

namespace BankApp.Data.Repositories
{
    public class AccountRepository: IAccountRepository
    {
        private BankAppDataContext _ctx;
        public AccountRepository(BankAppDataContext bankAppContext)
        {
            _ctx = bankAppContext;
        }
    
        public bool CreateAccount(Account account)
        {
            _ctx.Accounts.Add(account);
            _ctx.SaveChanges();
            return true;
        }
        public Account GetAccount(string AccountNumber)
        {
            var _accountNumber = _ctx.Accounts.Where(x => x.AccNumber == AccountNumber).FirstOrDefault();
            if(_accountNumber == null)
            {
                System.Console.WriteLine("Account number does not exist.");
            }
            return _accountNumber;
        }
        public bool Deposit(string accountNumber, decimal amount)
        {
            var account = _ctx.Accounts.Where(x => x.AccNumber == accountNumber).FirstOrDefault();
            account.AcctBalance += amount;
            _ctx.SaveChanges();
            return true;
        }
        public bool Withdrawal(string accountNumber, decimal amount)
        {
            var account = _ctx.Accounts.Where(x => x.AccNumber == accountNumber).FirstOrDefault();
            account.AcctBalance -= amount;
            _ctx.SaveChanges();
            return true;
        }
        public bool Transfer(string accountNumber, string beneficiaryAccNumber, decimal amount, string description)
        {
            var senderAcc = _ctx.Accounts.FirstOrDefault(acc => acc.AccNumber == accountNumber);
            var recAcc = _ctx.Accounts.FirstOrDefault(acc => acc.AccNumber == beneficiaryAccNumber);
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount must be greater than zero");
            }
            else
            {
                if (senderAcc.AcctType == "Savings" && senderAcc.AcctBalance > amount)
                {
                    senderAcc.AcctBalance -= amount;
                    recAcc.AcctBalance += amount;
                }
                if (senderAcc.AcctType == "Current")
                {
                    senderAcc.AcctBalance -= amount;
                    recAcc.AcctBalance += amount;
                }
            }
            _ctx.SaveChanges();
            return true;
        }
        public decimal GetAccountBalane(string account)
        {
            var balance = _ctx.Accounts.FirstOrDefault(x => x.AccNumber == account);
            return balance.AcctBalance;
        }
        public bool Exist(string accnumber)
        {
            return _ctx.Accounts.Any(a => a.AccNumber == accnumber);
        }        
    }
}
