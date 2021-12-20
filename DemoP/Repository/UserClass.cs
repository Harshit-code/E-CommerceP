using DemoP.IRepository;
using DemoP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoP.Repository
{
    public class UserClass : UserInterface
    {
        string str = string.Empty;
        private readonly DemoProjectContext context;
        public UserClass(DemoProjectContext _context)
        {
            context = _context;
        }
        IEnumerable<Models.UserTable> UserInterface.GetUser()
        {
            var response = context.UserTable.ToList();
            return response;
        }

        public string Insert(Models.UserTable model)
        {
            try
            {
               
                context.UserTable.Add(model);
                //Guid guid = model.Id;
                context.SaveChanges();
                
                str = "User saved successfully.";
            }
            catch (Exception ex)
            {
                str = "Deletion Failed due to=" + ex.Message + ".";
            }
            return str;
        }

        Models.UserTable UserInterface.GetByUserGuid(Guid id)
        {
            var response = context.UserTable.FirstOrDefault(x => x.Id == id);
            return response;
        }
        public UserTable GetIdByEmail(string email)
        {
            var response = (from user in context.UserTable
                            where user.Email == email
                            select user).FirstOrDefault();
            return response;
        }
    }
   
}
