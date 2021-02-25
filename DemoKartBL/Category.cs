using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
   public class Category
    {
       public static List<Product> Electronics { get; set; } = new List<Product>();
        public static List<Product> Clothing { get; set; } = new List<Product>();
        public static List<Product> Grocery { get; set; } = new List<Product>();
        public static List<Product> Cosmetics { get; set; } = new List<Product>();




        public void addproducts()
        {
           
            Product[] Productobj = new Product[20];
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


    }
}
