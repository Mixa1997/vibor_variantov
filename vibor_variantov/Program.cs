using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vibor_variantov
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double y, x, a, b, z;
                Console.Write("Введите x:");
                x = double.Parse(Console.ReadLine());
                a = 8.7;
                b = 3.7;
                z = Math.Tan(b * x);
                y = ((x * Math.E) + (z + 7.7) * (a * b * x));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Результат y:" + y + " ");

                z = Math.Tan(a * b * x);
                y = (Math.Tan(a * x + z) + Math.Cos(b * x));
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Результат y:" + y +" ");

                z = Math.Tan(Math.Sqrt(b) * x);
                y = (Math.Log(Math.Sin(a + b * x + z * Math.Sqrt(x))));
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Результат y:" + y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
