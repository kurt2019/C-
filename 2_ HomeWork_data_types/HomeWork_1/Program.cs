using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Для укр мови */
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            Console.WriteLine("Введіть ваше значення метрів");
            double meters = Convert.ToDouble(Console.ReadLine());
            double sant = meters * 100;

            Console.WriteLine($"\nВаше значення в сантиметрах {sant} см");

            Console.ReadKey();
        }
    }
}
