using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal
{
    public class User
    {
        public string userName { get; private set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public User(string userName)
        {
            this.userName = userName;
        }
       
    }
}