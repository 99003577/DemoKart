using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Cart
    {
        

        public int AddtoCart(int quantity)
        {

            if (quantity > 20)
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
