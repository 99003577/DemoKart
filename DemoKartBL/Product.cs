using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Product
    {
        public int productid = 0;
        public String productName = null;
        public int quantity = 0;
        public double price = 0;




        public Product(int productid, String productName, double price, int quantity)
        {
            this.productid = productid;
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
