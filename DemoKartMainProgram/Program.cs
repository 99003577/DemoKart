﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKartBL;

namespace DemoKartMainProgram
{
    public class Program
    {
<<<<<<< HEAD
        public static List<Product> Cart_list { get; set; } = new List<Product>();




        public void showitems(int id)
        {
                   
            
              foreach(Product item in Category.Mainitems)
                {
                if (id == item.CategoryObj.categoriesId)
                {
                    

=======
        
       
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
>>>>>>> 2c015fbf1b1666566e11617045066043d1096631
                    Console.WriteLine("Product id: " + item.productid);
                    Console.WriteLine("Product name: " + item.productName);
                    Console.WriteLine("Product price: " + item.price);
                    Console.WriteLine("Product quantity: " + item.quantity);
<<<<<<< HEAD
                    Console.WriteLine("Category Id : " + item.CategoryObj.categoriesId);
                    Console.WriteLine("Category Name " + item.CategoryObj.categories + "\n");

=======

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
>>>>>>> 2c015fbf1b1666566e11617045066043d1096631

                }
            }
        }
<<<<<<< HEAD
     


=======
>>>>>>> 2c015fbf1b1666566e11617045066043d1096631

        static void Main(string[] args)
        {
            User credentials = new User();
<<<<<<< HEAD
           
            Category product_Object = new Category();
            Program display = new Program();
            Cart cart_Object = new Cart();
            Payment payment_object = new Payment();
            product_Object.addproducts();
            int quant;
            double totalprice1 = 0 ,totalprice2 = 0, totalprice3 = 0, totalprice4 = 0;
            double initialprice1 = 0, initialprice2 = 0, initialprice3 = 0, initialprice4 = 0;
            int orderid = 0001;



=======
            Category prod = new Category();
            Program display = new Program();
            prod.addproducts();
            
                             
>>>>>>> 2c015fbf1b1666566e11617045066043d1096631
           Console.WriteLine("Welcome to our store");

            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
<<<<<<< HEAD
            Console.WriteLine("Please enter your Password");
            string password = Console.ReadLine();


=======
            Console.WriteLine("Please enter your username");
            string password = Console.ReadLine();

>>>>>>> 2c015fbf1b1666566e11617045066043d1096631
           
                    
            if ( credentials.logindetails(username, password) == 1)
            {
<<<<<<< HEAD
                int category_choice = 0;
                int choice;
                int n;
             
                {
                    Console.WriteLine("These are the categories we deal with");
                    do
                    {

                        Console.WriteLine("1.Electronics \n2.Clothing \n3.Grocery \n4.Cosmetics\n");
                        category_choice = Convert.ToInt32(Console.ReadLine());

                        display.showitems(category_choice);
                                                     
                                           
                        Console.WriteLine("\nEnter the ID of Product You Want Add to Cart : ");
                        int product_Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter How Many Quantity You Want");
                        quant = Convert.ToInt32(Console.ReadLine());
                        foreach (Product item in Category.Mainitems)
                        {
                            if (product_Id == item.productid)
                            {

                                totalprice1 = payment_object.Tax(item.CategoryObj.categoriesId, item.price, quant);
                                initialprice1 = totalprice1 + initialprice1;
                                Product cust_cart = new Product(item.productid, item.productName, item.price, quant, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                Cart_list.Add(cust_cart);
                                Console.WriteLine("Add To cart Is Successfull\n");
                            }
                        }

                        Console.WriteLine("1.Visit different category   2.Checkout");
                        n = Convert.ToInt32(Console.ReadLine());

                    } while (n == 1);
                                    
                   }

           }

            else
            {
                Console.WriteLine("Sorry wrong credentials");
            }
            //print cart
            foreach (Product item in Cart_list)
            {

                Console.WriteLine("Product id : " + item.productid);
                Console.WriteLine("Product Name : " + item.productName);
                Console.WriteLine("Product Price : " + item.price);
                Console.WriteLine("Product Quantity : " + item.quantity);
                Console.WriteLine("Category Id : " + item.CategoryObj.categoriesId);
                Console.WriteLine("Category Name " + item.CategoryObj.categories + "\n");


                Console.WriteLine("\n");
            }

            Console.WriteLine("Please Enter full name");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter your phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("Please enter your address");
            string address = Console.ReadLine();
            Console.WriteLine("Please enter your pincode");
            int pin = Convert.ToInt32(Console.ReadLine());
            orderid++;

            double TotalPrice = initialprice1 + initialprice2 + initialprice3 + initialprice4; 
            Console.WriteLine("Enter Payment method");
            Console.WriteLine("1.ByCash   2.ByCard");
            int paymentchoice = Convert.ToInt32(Console.ReadLine());
           //payment done by cash
            if(paymentchoice == 1)
            {
                Console.WriteLine("Final price is : " + TotalPrice);
            }
            //payment done by card
            else if (paymentchoice == 2)
            {
                Console.WriteLine("Final price is : " + payment_object.Payment_method(TotalPrice));
            }
            
            Console.WriteLine("Order successfully placed!\n");

            Console.WriteLine("Order id : " + orderid + "\n"+  "Order name : " + name + "\n" + "Order Address : " + address + "\n" + "Phone number : " + phone + "\n");
=======
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



>>>>>>> 2c015fbf1b1666566e11617045066043d1096631




<<<<<<< HEAD
            Console.WriteLine("Thank You for shopping with us");



            Console.ReadKey();
         
=======

            }

            else
            {
                Console.WriteLine("Sorry wrong credentials");
            }

            
           
>>>>>>> 2c015fbf1b1666566e11617045066043d1096631

        }
    }
}
