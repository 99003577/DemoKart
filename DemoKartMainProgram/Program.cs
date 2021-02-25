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
        public static List<Product> Cart_list { get; set; } = new List<Product>();
        static List<User> UserList = new List<User>(20);



        public void showitems(int id)
        {
                   
            
              foreach(Product item in Product.Mainitems)
                {
                if (id == item.CategoryObj.categoriesId)
                {
                    

                    Console.WriteLine("Product id: " + item.productid);
                    Console.WriteLine("Product name: " + item.productName);
                    Console.WriteLine("Product price: " + item.price);
                    Console.WriteLine("Product quantity: " + item.quantity);
                    Console.WriteLine("Category Id : " + item.CategoryObj.categoriesId);
                    Console.WriteLine("Category Name " + item.CategoryObj.categories + "\n");


                }
            }
        }
     



        static void Main(string[] args)
        {
            User credentials = new User();
           
            Category Category_object = new Category();
            Product product_Object = new Product();
            Program display = new Program();
            Cart cart_Object = new Cart();
            Payment payment_object = new Payment();
            product_Object.addproducts();
            int quant;
            double totalprice1 = 0;
            double initialprice1 = 0, initialprice2 = 0, initialprice3 = 0, initialprice4 = 0;
            int orderid = 0001;



           Console.WriteLine("Welcome to our store");

            Console.WriteLine("Please Signup to proceed further");

            Console.WriteLine("Enter User Name for Sign Up");
            String userName = Console.ReadLine();
            Console.WriteLine("Enter Password for Sign Up");
            String password = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number ");
            long phone = Convert.ToInt64(Console.ReadLine());

            User UserObj = new User(userName, password, phone);
            UserList.Add(UserObj);
            Console.WriteLine("Signup Successful!!");
            Console.WriteLine("1.Display Sign Up Details\t 2.Login");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                foreach (User item in UserList)
                {
                    Console.WriteLine("User Name : " + item.UserName);
                    Console.WriteLine("Password : " + item.Password);
                    Console.WriteLine("Phone number : " + item.phone);
                    break;
                }
            }
            else
            {


                Console.WriteLine("Please enter username");
                string userId = Console.ReadLine();
                Console.WriteLine("Please enter password:");
                string pass = Console.ReadLine();
                //int choice = credentials.LoginDetails(userId, pass);
                if (userId == userName && pass == password)
                {
                    int category_choice = 0;
                    int n;

                    {
                        Console.WriteLine("These are the categories we deal with");
                        do
                        {

                            Console.WriteLine("1.Electronics \n2.Clothing \n3.Grocery \n4.Cosmetics\n");
                            category_choice = Convert.ToInt32(Console.ReadLine());
                            //print the products
                            display.showitems(category_choice);


                            Console.WriteLine("\nEnter the ID of Product You Want Add to Cart : ");
                            int product_Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want to add");
                            quant = Convert.ToInt32(Console.ReadLine());
                            foreach (Product item in Product.Mainitems)
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
                    if (paymentchoice == 1)
                    {
                        Console.WriteLine("Final price is : " + TotalPrice);
                    }
                    //payment done by card
                    else if (paymentchoice == 2)
                    {
                        Console.WriteLine("Final price is : " + payment_object.Payment_method(TotalPrice));
                    }

                    Console.WriteLine("Order successfully placed!\n");

                    Console.WriteLine("Order id : " + orderid + "\n" + "Order name : " + userName + "\n" + "Order Address : " + address + "\n" + "Phone number : " + phone + "\n");




                    Console.WriteLine("Thank You for shopping with us");



                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Sorry wrong credentials");
                }
            }
        }
    }
}
