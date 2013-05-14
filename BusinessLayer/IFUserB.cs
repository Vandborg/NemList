using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelLayer;
using DAL;

namespace BusinessLayer
{
    public interface IFUserB
    {
        void CreateUser(string fname, string lname, string uname, string email);
        ModelLayer.User GetUserById(int id);
    }
}
