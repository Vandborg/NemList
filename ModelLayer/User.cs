using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ModelLayer
{
    [DataContract]
    public class User
    {
        [DataMember]
        private int _userId;
        [DataMember]
        private string FName { get; set; }
        [DataMember]
        private string LName { get; set; }
        [DataMember]
        private string UserName { get; set; }
        [DataMember]
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
