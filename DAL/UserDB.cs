using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace DAL
{
    public class UserDb
    {
        public void CreateUser(string fname, string lname, string uname, string email)
        {
            using (var db = new BalderDataContext())
            {
                User u = new User();

                u.FName = fname;
                u.LName = lname;
                u.UserName = uname;
                u.Email = email;

                db.Users.InsertOnSubmit(u);
                db.SubmitChanges();
            }
        }
    }
}
