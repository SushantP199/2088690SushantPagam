using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Seller Name");
            string seller_name = Console.ReadLine();

            Console.WriteLine("Enter the Product Name");

            string product_name = Console.ReadLine();

            Console.WriteLine("Enter quantity");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Either returnable or not ?  true / false ");
            bool isReturnable = bool.Parse(Console.ReadLine());

            Program p = new Program();

            p.OrderDetails(seller_name, product_name, quantity, isReturnable);

            p.OrderDetails(seller_name, product_name);
        }

        public void OrderDetails(string seller_name, string product_name, int quantity = 1, bool isReturnable = true)
        {
            Console.WriteLine($"Here is the order detail – {quantity} number of {product_name} by {seller_name} is ordered. It’s returnable status is {isReturnable}");
        }
    }
}
