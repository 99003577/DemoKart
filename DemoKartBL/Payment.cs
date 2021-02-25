using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
   public class Payment
    {
        public double Payment_method(double finalprice)
        {
            double totalprice = finalprice;
            //for card
                double tax = finalprice * 0.33;
                totalprice = finalprice + tax;
                return totalprice;
                
            
            
        }

        public double Tax(int category_choice, int price, int quantity)
        {
            double gst = 0.18;
            double finalprice = 0;
            double totaltax;
            int total = price * quantity;

            if (category_choice == 1)
            {
                gst = 0.18;
                totaltax = total * gst;
                finalprice = totaltax + total;
                return finalprice;
            }
            else if (category_choice == 2)
            {
                gst = 0.07;
                totaltax = price * gst;
                finalprice = totaltax + price;
                return finalprice;
            }
            else if (category_choice == 3)
            {
                gst = 0.04;
                totaltax = price * gst;
                finalprice = totaltax + price;
                return finalprice;
            }
            else
            {
                totaltax = price * gst;
                finalprice = totaltax + price;
                return finalprice;
            }
        }

         

    }
}
