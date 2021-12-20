using DemoP.IRepository;
using DemoP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoP.Repository
{
    public class CustomerTable : CustomerInterface
    {

        string str = string.Empty;
        private readonly DemoProjectContext context;
        public CustomerTable(DemoProjectContext _context)
        {
            context = _context;
        }
        public IEnumerable<Models.Customer> GetCustomer()
        {
            var response = context.Customer.ToList();
            return response;
        }

        public string Insert(Models.Customer model)
        {
            try
            {

                context.Customer.Add(model);
                context.SaveChanges();
                str = "User Added successfully.";
            }
            catch (Exception ex)
            {
                str = "Deletion Failed due to=" + ex.Message + ".";
            }
            return str;
        }

        Models.Customer CustomerInterface.GetByCustomerGuid(Guid id)
        {
            return context.Customer.FirstOrDefault(x => x.UserId == id);
        }
    }
}
