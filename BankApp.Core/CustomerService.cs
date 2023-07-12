using BankApp.Core.IService;
using BankApp.Data.Interfaces;
using BankApp.Data.Repositories;
using BankApp.Models;

namespace BankApp.Core
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _custRepo;

        private readonly IAccountService _acctService;
        //ITransactionService _tranService = new TransactionService(new TransactionRepository());
        public CustomerService(ICustomerRepository cust, IAccountService acctService)
        {
            _custRepo = cust;
            _acctService = acctService;
        }

        public Customer Create(string FirstName, string LastName, string Email, string Password, decimal initialDeposit, string accountType)
        {
            Customer customer = new Customer()
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Password = Password
            };
            _custRepo.Create(customer);
            _acctService.CreateAccount(accountType, initialDeposit, customer.CustomerId);
            return customer;
        }
        public Customer RetrieveCustomer(string email)
        {
            return _custRepo.RetrieveCustomer(email);
        }
        public bool Login(string email, string password)
        {
            return _custRepo.AuthCustomer(email, password);
        }
        //public bool Logout()
        //{
        //    return Environment.ExitCode();
        //}
    }
}
