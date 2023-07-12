using BankApp.Core;
using BankApp.Core.IService;
using BankApp.Data;
using BankApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.UI
{
    class GlobalConfig
    {
        public static IAccountService _accountService { get; set; }
        public static ICustomerService _customerService { get; set; }
        public static ITransactionService _transactionService { get; set; }

        public static void AddInstance()
        {
            var context = new BankAppDataContext();
            AccountRepository accountRepositories = new AccountRepository(context);
            _accountService = new AccountService(accountRepositories);

            

            CustomerRepository customerRepository = new CustomerRepository(context);
            _customerService = new CustomerService(customerRepository, _accountService);

            //TransactRepository transactionRepository = new TransactRepository();
            //_transactionService = new TransactionService(transactionRepository);
        }
        public static void RemoveInstance()
        {
            _accountService = null;
            _customerService = null;
            _transactionService = null;
        }
    }
}
