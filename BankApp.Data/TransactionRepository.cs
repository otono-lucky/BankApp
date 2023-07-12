using BankApp.Data.Interfaces;
using BankApp.Models;
using System;
using System.Linq;

namespace BankApp.Data.Repositories
{
    public class TransactRepository : ITransactRepository
    {
        private readonly BankAppDataContext _ctx;

        public TransactRepository()
        {
        }

        public TransactRepository(BankAppDataContext bankappcontext)
        {
            _ctx = bankappcontext;
        }
        public void AddTransaction(Transact transact)
        {
            _ctx.Transactions.Add(transact);
            _ctx.SaveChanges();
        }

        public Transact AddTransaction(string Acct, decimal Amount, string TransactionType, DateTime date, string Note)
        {
            throw new NotImplementedException();
        }

        public Transact RetrieveTransaction(string accountNumber)
        {
            var transaction = _ctx.Transactions.Where(x => x.AcctNumber == accountNumber).FirstOrDefault();
            return transaction;
        }
        public Transact RetrieveTransaction(string Acct, decimal Amount, DateTime date, string Note)
        {
            throw new NotImplementedException();
        }
    }
}
