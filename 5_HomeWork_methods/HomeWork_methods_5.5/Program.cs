using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5._5
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"> количество грн </param>
        /// <param name="b"> курс валюти </param>
        /// <param name="c"> название валюты в которую конвертируем </param>
        static void СonvertMoney(double a, double b, string c)
        {
            if (c == "USD" || c == "usd" || c == "Usd")
            {
                double result = a * b;
                Console.WriteLine($"{a} грн в долари = {result}");
            }
            else if (c == "EUR" || c == "eur" || c == "Eur")
            {
                double result = a * b;
                Console.WriteLine($"{a} грн в евро = {result}");
            }
            else if (c == "RUB" || c == "rub" || c == "Rub")
            {
                double result = a * b;
                Console.WriteLine($"{a} грн в рубли = {result}");
            }
            else
            {
                Console.WriteLine("Такая валюта мне неизвестна");
            }
        }

        static void СonvertMoney(double a, double b)
        {
            double result = a * b;
            Console.WriteLine($"Количество валюти : {a} конвертируем по курсу {b} = {result}");
        }



        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу для конвертирования валюты. Пользователь должен иметь
            возможность ввести курс валюты, в которую он хочет конвертировать, сумму 
            которую он хочет конвертировать.  Программа должна вывести сумму денег в соответствующей валюте.
            */

            Console.WriteLine("Есле вы хотете конвертировать в одну из валют: долари, евро,рубли\n Bведите: Yes иначе будет запучена простая версия: ");
            string answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                Console.WriteLine("Введите суму которую хотите конвертировать:");
                double sumUA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите курс по которому будем конвертировать:");
                double course = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите в какую валюту: RUB, EUR, USD");
                string NameMoney = Console.ReadLine();

                СonvertMoney(sumUA, course, NameMoney);
            }
            else
            {
                Console.WriteLine("Введите суму которую хотите конвертировать:");
                double sumUA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите курс по которому будем конвертировать:");
                double course = Convert.ToDouble(Console.ReadLine());

                СonvertMoney(sumUA, course);
            }

            Console.ReadKey();
        }
    }
}
