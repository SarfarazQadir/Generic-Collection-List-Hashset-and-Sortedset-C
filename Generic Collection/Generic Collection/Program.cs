using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string item;
           List<string> li = new List<string>();
           Console.WriteLine("How many items are you added in your cart");
           int n = int.Parse(Console.ReadLine());

           for (int i = 0; i < n; i++)
           {
               Console.WriteLine("Enter Item name");
               item = Console.ReadLine();
               li.Add(item);
               Console.Clear();
           }
           Console.WriteLine("Your Items is sucessfully add in your cart");
           Console.ReadLine();

           foreach (var data in li)
           {
               Console.WriteLine(data);
           }
           Console.ReadKey();  */

            //Dynamic Collection

            List<Product> li = new List<Product>();
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine("How many Products you want to add?");
            Console.ForegroundColor = System.ConsoleColor.White;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Product names");
                Product myproduct = new Product();
                myproduct.Product_name = Console.ReadLine();
                myproduct.Product_id = i + 1;
                li.Add(myproduct);


                Console.Clear();
            }

            Console.WriteLine("SuccessFully added...");

            foreach (var item in li)
            {
                Console.WriteLine("Product Id : " + item.Product_id);
                Console.WriteLine("Product Name : " + item.Product_name);
            }

            /* var li = new HashSet<string>();
             li.Add("a");
             li.Add("a");
             li.Add("b");
             li.Add("c");
             li.Add("c");
             li.Add("d");

             foreach (var item in li)
             {
                 Console.WriteLine(item);
             }*/
            /* var list = new SortedSet<string>();
             list.Add("t");
             list.Add("a");
             list.Add("z");
             list.Add("c");
             list.Add("c");
             list.Add("e");

             foreach (var item in list)
             {
                 Console.WriteLine(item);
             }*/
            Console.ReadKey();
        }
    }
}
