using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b)

                if (a > c) Console.WriteLine("A is the biggest");

                else if (a < c) Console.WriteLine("C is the biggest");

                else Console.WriteLine("A and C are the biggest");

            else if (a < b)

                if (b > c) Console.WriteLine("B is the biggest");

                else if (b < c) Console.WriteLine("C is the biggest");

                else Console.WriteLine("B and C are the biggest");

            else if (a == b)

                if (a == c) Console.WriteLine("All are equal");

                else if (a < c) Console.WriteLine("C is the biggest");

                else Console.WriteLine("A and B are the biggest");
        }
            
    }
}
