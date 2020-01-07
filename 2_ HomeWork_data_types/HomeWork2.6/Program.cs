using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Для укр мови */
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть ціну товару:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть знижку на товар:");
            double discount = Convert.ToDouble(Console.ReadLine());

            /* Розрахунок знижки */
            double resultDiscont = (price * discount) / 100;
            /* Розрахунок остаточної суми товару з урахуванням знижки */
            double priceAfter = price - (price * discount) / 100;


            Console.WriteLine($"Ціна товару {price}\nЗнижка на товар {discount}%\n");
            Console.WriteLine($"Сума знижки на товар {resultDiscont}\n");
            Console.WriteLine($"Ціна з урахуванням знижки на товар {priceAfter}\n");


            Console.ReadKey();
        }
    }
}
