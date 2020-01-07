using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Для укр мови */
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            Console.WriteLine("Введіть значення для 1-го катета");
            double cat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Введіть значення для 2-го катета");
            double cat2 = Convert.ToDouble(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));

            Console.WriteLine($"Гіпотенуза = {hypotenuse}");

            Console.ReadKey();
        }
    }
}
