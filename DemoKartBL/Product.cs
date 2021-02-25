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



        public Product()
        {

        }
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


        public void addproducts()
        {

            Product[] Productobj = new Product[20];
            //adding items

            for (int i = 0; i < 20; i++)
            {

                Productobj[0] = new Product(1, "Mobile", 10000, 10, 1, "Electronics");
                Productobj[1] = new Product(2, "Laptop", 30000, 15, 1, "Electronics");
                Productobj[2] = new Product(3, "Telivision", 20000, 20, 1, "Electronics");
                Productobj[3] = new Product(4, "Charger", 200, 10, 1, "Electronics");
                Productobj[4] = new Product(5, "Headset", 1000, 10, 1, "Electronics");
                Productobj[5] = new Product(6, "Kids", 500, 100, 2, "Clothing");
                Productobj[6] = new Product(7, "Gents", 1000, 120, 2, "Clothing");
                Productobj[7] = new Product(8, "Ladies", 1000, 150, 2, "Clothing");
                Productobj[8] = new Product(9, "Western", 2000, 100, 2, "Clothing");
                Productobj[9] = new Product(10, "Tradition", 2000, 100, 2, "Clothing");
                Productobj[10] = new Product(11, "Rice", 1000, 100, 3, "Grocery");
                Productobj[11] = new Product(12, "Bread", 1000, 50, 3, "Grocery");
                Productobj[12] = new Product(13, "Sugar", 1000, 100, 3, "Grocery");
                Productobj[13] = new Product(14, "Salt", 1000, 50, 3, "Grocery");
                Productobj[14] = new Product(15, "Milk", 1000, 20, 3, "Grocery");
                Productobj[15] = new Product(16, "Perfume", 500, 10, 4, "Cosmetics");
                Productobj[16] = new Product(17, "Lotion", 200, 15, 4, "Cosmetics");
                Productobj[17] = new Product(18, "Powder", 500, 20, 4, "Cosmetics");
                Productobj[18] = new Product(19, "Shampoo", 500, 30, 4, "Cosmetics");
                Productobj[19] = new Product(20, "Lipstick", 500, 20, 4, "Cosmetics");



                Mainitems.Add(Productobj[i]);

            }







        }
    }
}
