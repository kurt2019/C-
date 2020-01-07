using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Для укр мови */
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            /* А це взагалі тригонометрія */

            Console.WriteLine("Введіть значення для визначення синуса:");
            double corner = Convert.ToDouble(Console.ReadLine());

            double sin = Math.Sin(corner*(Math.PI/180));

            Console.WriteLine($"Значення синуса {sin}");


            Console.ReadKey();
        }
    }
}
