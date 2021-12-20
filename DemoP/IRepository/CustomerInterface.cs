using DemoP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoP.IRepository
{
    public interface CustomerInterface
    {
        public IEnumerable<Customer> GetCustomer();
        public string Insert(Customer model);
        public Customer GetByCustomerGuid(Guid id);
    }
}
