using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
   public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public int logindetails(string username,string password)
        {
           string user = "user";
            string pass = "pass";
            if(username == user &&  password == pass)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


    }
}
