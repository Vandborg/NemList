using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLayer
{
    public class User
    {
        private int _userId;
        private string FName { get; set; }
        private string LName { get; set; }
        private string UserName { get; set; }
        private string Email { get; set; }

        public User(string fname, string lname, string uname, string email)
        {
            FName = fname;
            LName = lname;
            UserName = uname;
            Email = email;

        }

        public int UserId
        {
            get { return _userId; }
        }
    }

}
