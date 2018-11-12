using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a, b, c for: ax^2 + bx + c = 0");
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int D = b ^ 2 - 4 * a * c;
            if (D == 0)
            {
                Console.WriteLine("x1 = x2 = {0}", -b / 2 * a);
            }
            else if (D > 0)
            {
                Console.WriteLine("x1 = {0}, x2 = {1}", (-b + Math.Sqrt(D)) / 2 * a, (-b - Math.Sqrt(D)) / 2 * a);
            }
            else
            {
                Console.WriteLine("No result.");
            }
        }
    }
}
