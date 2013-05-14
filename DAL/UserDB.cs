using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace DAL
{
    class UserDb
    {
        void CreateUser(string fname, string lname, string uname, string email)
        {
            using (var db = new BalderDataContext())
            {
                User u = new User();

                fname = u.FName;
                lname = u.LName;
                uname = u.UserName;
                email = u.Email;

                db.Users.InsertOnSubmit(u);
                db.SubmitChanges();
            }
        }
    }
}
