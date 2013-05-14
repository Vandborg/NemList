using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelLayer;
using DAL;

namespace BusinessLayer
{
    public class UserB : IFUserB
    {
        public int CreateUser(string fname, string lname, string uname, string email)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
   
}
