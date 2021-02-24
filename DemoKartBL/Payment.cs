using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    class Payment
    {
        public double Payment_method(int payment_choice,double finalprice)
        {
            double totalprice = finalprice;
            //for cash
            if(payment_choice == 1)
            {
                return totalprice;
            }
            else 
            {
                double tax = finalprice * 0.33;
                totalprice = finalprice + tax;
                return totalprice;
                
            }
            
        }



    }
}
