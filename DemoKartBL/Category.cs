using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
   public class Category
    {
<<<<<<< HEAD
        public int categoriesId { get; set; }
        public String categories { get; set; }

        public static List<Product> Mainitems { get; set; } = new List<Product>();
=======
       public static List<Product> Electronics { get; set; } = new List<Product>();
>>>>>>> 2c015fbf1b1666566e11617045066043d1096631
        public static List<Product> Clothing { get; set; } = new List<Product>();
        public static List<Product> Grocery { get; set; } = new List<Product>();
        public static List<Product> Cosmetics { get; set; } = new List<Product>();




        public void addproducts()
        {
           
            Product[] Productobj = new Product[20];
<<<<<<< HEAD
            //for electronics
            for (int i = 0; i < 20; i++)
            { 
                
            Productobj[0] = new Product(1, "Mobile", 10000, 10,1,"Electronics");
            Productobj[1] = new Product(2, "Laptop", 30000, 15, 1, "Electronics");
            Productobj[2] = new Product(3, "Telivision", 20000, 20,1, "Electronics");
            Productobj[3] = new Product(4, "Charger", 200, 10, 1, "Electronics");
            Productobj[4] = new Product(5, "Headset", 1000, 10, 1, "Electronics");
            Productobj[5] = new Product(6, "Kids", 500, 100 ,2,"Clothing");
            Productobj[6] = new Product(7, "Gents", 1000, 120, 2, "Clothing");
            Productobj[7] = new Product(8, "Ladies", 1000, 150, 2, "Clothing");
            Productobj[8] = new Product(9, "Western", 2000, 100, 2, "Clothing");
            Productobj[9] = new Product(10, "Tradition", 2000, 100, 2, "Clothing");
            Productobj[10] = new Product(11, "Rice", 1000, 100,3, "Grocery");
            Productobj[11] = new Product(12, "Bread", 1000, 50,3, "Grocery");
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

            
=======
            for (int i = 0; i < 3; i++)
            { 
            Productobj[0] = new Product(1, "Elec name", 20.00, 100);
            Productobj[1] = new Product(2, "Elec name2", 20.00, 100);
            Productobj[2] = new Product(3, "Elec name3", 20.00, 100);
            Electronics.Add(Productobj[i]);

            }
            for (int i = 0; i < 3; i++)
            {
                Productobj[0] = new Product(1, "Clot name", 20.00, 100);
                Productobj[1] = new Product(2, "Clot name2", 20.00, 100);
                Productobj[2] = new Product(3, "Clot name3", 20.00, 100);
                Clothing.Add(Productobj[i]);

            }
            for (int i = 0; i < 3; i++)
            {
                Productobj[0] = new Product(1, "Gro name", 20.00, 100);
                Productobj[1] = new Product(2, "Gro name2", 20.00, 100);
                Productobj[2] = new Product(3, "Gro name3", 20.00, 100);
                Grocery.Add(Productobj[i]);

            }
            for (int i = 0; i < 3; i++)
            {
                Productobj[0] = new Product(1, "Cos name", 20.00, 100);
                Productobj[1] = new Product(2, "Cos name2", 20.00, 100);
                Productobj[2] = new Product(3, "Cos name3", 20.00, 100);
                Cosmetics.Add(Productobj[i]);

            }

>>>>>>> 2c015fbf1b1666566e11617045066043d1096631




<<<<<<< HEAD
        }
       
       
=======



        }
        /*
        public void display(int id)
        {

            if (id == 1)
            {
                foreach (Product item in Electronics)
                {
                    Console.WriteLine("Product id: " + item.productid);
                    Console.WriteLine("Product name: " + item.productName);
                    Console.WriteLine("Product price: " + item.price);
                    Console.WriteLine("Product quantity: " + item.quantity);

                }
            }

        }
        */























        public double Tax(int category_choice,int price)
        {
            double cgst = 0.18;
            double finalprice = 0;
            double totaltax;

            if (category_choice == 1)
            {
                cgst = 0.18;
                totaltax = price * cgst;
                finalprice = totaltax + price;
                return finalprice;
            }
            else if (category_choice == 2)
            {
                cgst = 0.07;
                totaltax = price * cgst;
                finalprice = totaltax + price;
                return finalprice;
            }
            else if(category_choice == 3)
            {
                cgst = 0.04;
                totaltax = price * cgst;
                finalprice = totaltax + price;
                return finalprice;
            }
            else
            {
                totaltax = price * cgst;
                finalprice = totaltax + price;
                return finalprice;
            }
        }
>>>>>>> 2c015fbf1b1666566e11617045066043d1096631


    }
}
