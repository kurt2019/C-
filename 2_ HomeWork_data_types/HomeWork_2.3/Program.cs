using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Для укр мови */
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            const decimal pi = 3.141592653589793238462643m;
            Console.WriteLine("Введіть значення для радіуса");
            double r = Convert.ToDouble(Console.ReadLine());
            decimal pow = Convert.ToDecimal(Math.Pow(r, 2));

            decimal payment = Convert.ToDecimal((pi * pow));
            Console.WriteLine($"\nПлоща кола = {payment}");

            Console.WriteLine("\nМи за точність)))");

            Console.ReadKey();
        }
    }
}
