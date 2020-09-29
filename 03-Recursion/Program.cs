using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.Read();
        }

        static long Factorial(long number)
        {
            if(number <= 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine($"Number {number}: {number * Factorial(number - 1)}");
                return number * Factorial(number - 1);
            }
        }
    }
}
