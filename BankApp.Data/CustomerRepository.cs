using BankApp.Data.Interfaces;
using BankApp.Models;
using System.Linq;

namespace BankApp.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private BankAppDataContext _ctx;
        public CustomerRepository(BankAppDataContext bankAppContext)
        {
            _ctx = bankAppContext;
        }
        public bool Create(Customer newCus)
        {
            _ctx.Customers.Add(newCus);
            _ctx.SaveChanges();
            return true;
        }
        public Customer RetrieveCustomer(string email)
        {
            var customer = _ctx.Customers.Where(x => x.Email == email).FirstOrDefault();
            return customer;
        }
        public bool Exist(string email)
        {
            return _ctx.Customers.Any(r => r.Email == email);
        }
        public bool AuthCustomer(string Email, string password)
        {
            if (Exist(Email) && (password == RetrieveCustomer(Email).Password))
                return true;
            return false;
        }
    }
}
