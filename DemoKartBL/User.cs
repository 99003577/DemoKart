using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
   public class User
    {

       public String UserName { get; set; }
        public String Password { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public long phone { get; set; }

        public User()
        {

        }
        public User(String UserName, String Password, long phone)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.phone = phone;
        }
        public int LoginDetails(String uName, String psword)
        {
            if (uName == UserName && psword == Password)
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
