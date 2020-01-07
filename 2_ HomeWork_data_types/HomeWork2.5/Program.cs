using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Для укр мови */
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            int one , two ;
            Console.WriteLine("Введіть числа для подальшого їх розрахунку:");
            Console.WriteLine("Введіть перше чило:");
            one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введіть друге чило:");
            two = Convert.ToInt32(Console.ReadLine());

            int sum = one + two;
            int sum1 = one - two;
            int sum2 = one / two;
            int sum3 = one * two;
            int sum4 = one % two;

            Console.WriteLine($"Додавання {sum}\n");
            Console.WriteLine($"Віднімання {sum1}\n");
            Console.WriteLine($"Ділення {sum2}\n");
            Console.WriteLine($"Множення {sum3}\n");
            Console.WriteLine($"Ділення за модулем {sum4}\n");

            Console.ReadKey();
        }
    }
}
