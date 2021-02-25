using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Category
    {
       

        public int categoriesId { get; set; }
        public String categories { get; set; }

      //  public static List<Product> Mainitems { get; set; } = new List<Product>();
        public static List<Product> Clothing { get; set; } = new List<Product>();
        public static List<Product> Grocery { get; set; } = new List<Product>();
        public static List<Product> Cosmetics { get; set; } = new List<Product>();

        







    }
}
