using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
                {
                Console.WriteLine("a = {0}, b = {1}", b, a);
                }
            else
                 {
                 Console.WriteLine("b > a");
                 }
        }
    }
}
