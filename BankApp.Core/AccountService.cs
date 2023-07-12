using BankApp.Core.IService;
using BankApp.Models;
using System;
using BankApp.Data.Repositories;

namespace BankApp.Core
{
    public class AccountService: IAccountService
    {
        private readonly AccountRepository _accRepo;
        private readonly CustomerRepository _custRepo;
        public AccountService(AccountRepository acct)
        {
            _accRepo = acct;
        }
        public AccountService(CustomerRepository customer)
        {
            _custRepo = customer;
        }
        public void CreateAccount(string AccType, decimal initialDeposit, int customerId)
        {
            Account account;
            if (AccType == "Savings")
            {
                account = new SavingsAccount(initialDeposit);
            }
            else
            {
                account = new CurrentAccount(initialDeposit);
            }
            account.AcctType = AccType;
            account.CustomerId = customerId;
            _accRepo.CreateAccount(account);
        }
        public bool Deposit(string accnumber, decimal amount, string note = "Deposit")
        {
            Account acc = _accRepo.GetAccount(accnumber);
            if (_accRepo.Exist(accnumber))
            {
                acc.AcctBalance += amount;
                _accRepo.Deposit(accnumber, amount);
                return true;
            }
            return false;
        }
        public string Withdraw(string accnumber, decimal amount, string note = "Withdrawal")
        {
            Account acct = null;
            {
                acct.AccNumber = accnumber;
                acct.AcctBalance = amount;
            };
            while (!_accRepo.Exist(accnumber))
            {
                Console.WriteLine("Incorrect account number.");
            }
            
            _accRepo.GetAccount(accnumber);
            _accRepo.Withdrawal(accnumber, amount);
            return $"Deposited {amount} and your new account balance is {acct.AcctBalance}";
        }
        public bool Transfer(string accnumber, string beneficiaryacc, decimal amount, string note)
        {
            if (_accRepo.Exist(accnumber))
            {
                Withdraw(accnumber, amount);
                Deposit(accnumber, amount, note);
            }
            Console.WriteLine("Account number does not exist.");
            return false;
        }
        public Account GetAccount(string AccountNumber)
        {
            return _accRepo.GetAccount(AccountNumber);
        }
        public decimal Balance(string account)
        {
            return _accRepo.GetAccountBalane(account);
        }
    }
}

