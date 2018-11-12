using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int a = int.Parse(Console.ReadLine());



            int b = int.Parse(Console.ReadLine());



            int c = int.Parse(Console.ReadLine());



            if (a < 0 && b < 0 && c < 0) Console.WriteLine("-");

            else if (a >= 0 && b >= 0 && c >= 0) Console.WriteLine("+");

            else if (a < 0 && b < 0 && c >= 0) Console.WriteLine("+");

            else if (a < 0 && b >= 0 && c < 0) Console.WriteLine("+");

            else if (a >= 0 && b < 0 && c < 0) Console.WriteLine("+");

            else if (a < 0 && b >= 0 && c >= 0) Console.WriteLine("-");

            else if (a >= 0 && b < 0 && c >= 0) Console.WriteLine("-");

            else if (a >= 0 && b >= 0 && c < 0) Console.WriteLine("-");
        }
    }
}
