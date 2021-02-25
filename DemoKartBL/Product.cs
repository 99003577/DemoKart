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
        public int price = 0;
        public Category CategoryObj = new Category();




        public Product(int productid, String productName, int price, int quantity, int categoryid, string Categories)
        {
            this.productid = productid;
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
            CategoryObj.categoriesId = categoryid;
            CategoryObj.categories = Categories;

        }

        public static List<Product> Mainitems { get; set; } = new List<Product>();

       







    }
}
