using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKartBL;

namespace DemoKartMainProgram
{
    public class Program
    {
        
       
        public void showitems(int id)
        {
            Category prod = new Category();
            
            //Electronics id
            if (id == 1)
            {
                foreach(Product item in Category.Electronics)
                {
                    Console.WriteLine("Product id: " + item.productid);
                    Console.WriteLine("Product name: " + item.productName);
                    Console.WriteLine("Product price: " + item.price);
                    Console.WriteLine("Product quantity: " + item.quantity);

                }
            }
            //Clothing
            else if(id == 2)
            {
                foreach (Product item in Category.Clothing)
                {
                    Console.WriteLine("Product id: " + item.productid);
                    Console.WriteLine("Product name: " + item.productName);
                    Console.WriteLine("Product price: " + item.price);
                    Console.WriteLine("Product quantity: " + item.quantity);

                }
            }
            //Grocery
            else if (id == 3)
            {
                foreach (Product item in Category.Grocery)
                {
                    Console.WriteLine("Product id: " + item.productid);
                    Console.WriteLine("Product name: " + item.productName);
                    Console.WriteLine("Product price: " + item.price);
                    Console.WriteLine("Product quantity: " + item.quantity);

                }
            }
            //Cosmetics
            else if (id == 4)
            {
                foreach (Product item in Category.Cosmetics)
                {
                    Console.WriteLine("Product id: " + item.productid);
                    Console.WriteLine("Product name: " + item.productName);
                    Console.WriteLine("Product price: " + item.price);
                    Console.WriteLine("Product quantity: " + item.quantity);

                }
            }
        }

        static void Main(string[] args)
        {
            User credentials = new User();
            Category prod = new Category();
            Program display = new Program();
            prod.addproducts();
            
                             
           Console.WriteLine("Welcome to our store");

            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your username");
            string password = Console.ReadLine();

           
                    
            if ( credentials.logindetails(username, password) == 1)
            {
                int choice;
                do
                {
                    Console.WriteLine("These are the categories we deal with");

                    Console.WriteLine("1.Electronics \n2.Clothing \n3.Grocery \n4.Cosmetics");
                    int category_choice = Convert.ToInt32(Console.ReadLine());

                    display.showitems(category_choice);
                    Console.WriteLine("Do you want to continue 1.continye 2.exit");
                    choice = Convert.ToInt32(Console.ReadLine());

                } while (choice == 1);








            }

            else
            {
                Console.WriteLine("Sorry wrong credentials");
            }

            
           

        }
    }
}
