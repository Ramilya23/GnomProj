using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnomProj
{
    public class User
    {
        public User(string m, string l, string p, string f)
        {
            mail = m;
            login = l;
            password = p;
            favanimal = f;
        }
        public string mail;
        public string login;
        public string password;
        public string favanimal;

    }
}
