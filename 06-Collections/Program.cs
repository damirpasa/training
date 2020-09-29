using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Collections
{
    class Program
    {
        static void Main()
        {
            // populate a List of strings
            var items = new List<string>();
            items.Add("aQua"); // add aQua to the end of the list
            items.Add("RusT");
            items.Add("yElLow");
            items.Add("rEd");

            // display initial List
            Console.Write("items contains:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine(); // output end of line

            // convert to uppercase, select those starting with "R" and sort
            var startsWithR =
                from item in items
                let uppercaseString = item.ToUpper()
                where uppercaseString.StartsWith("R")
                orderby uppercaseString
                select uppercaseString;

            // display query results
            Console.Write("results of query startsWithR:");
            foreach(var item in startsWithR)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();

            items.Add("rUbY");
            items.Add("SaFfRon");

            // display initial List
            Console.Write("items contains:");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            // display updated query results
            Console.Write("results of query startsWithR:");
            foreach(var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();
            Console.Read();
        }
    }
}
