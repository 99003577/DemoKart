using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
   public class Payment
    {
<<<<<<< HEAD
        public double Payment_method(double finalprice)
        {
            double totalprice = finalprice;
            //for card
=======
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
>>>>>>> 2c015fbf1b1666566e11617045066043d1096631
                double tax = finalprice * 0.33;
                totalprice = finalprice + tax;
                return totalprice;
                
<<<<<<< HEAD
            
            
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

         
=======
            }
            
        }


>>>>>>> 2c015fbf1b1666566e11617045066043d1096631

    }
}
