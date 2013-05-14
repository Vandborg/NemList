using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLayer;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ListService : IListService
    {
        private static IFUserB userObj = new UserB();

        public void CreateUser(string fname, string lname, string uname, string email)
        {
            userObj.CreateUser(fname, lname, uname, email);
        }
    }
}
