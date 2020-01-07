using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5._2
{
    class Program
    {
        /// <summary>
        /// Small number of 2 numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> small number </returns>
        static string SmallNumber(double a, double b)
        {
            if (a > b)
            {
                return $"Число {b} меньше чем {a}";
            }
            else if (b < a)
            {
                return $"Число {a} меньше чем {b}";
            }
            else
            {
                return "Введение значения равны";
            }
        }

        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу в которой создайте метод, который в качестве аргументов
            принимает 2 числа и возвращает меньшее из них.
            */

            Console.WriteLine("Введите 2 числа для их сравнения:\n");

            Console.WriteLine("Введите первое число:");
            double number_1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double number_2 = Double.Parse(Console.ReadLine());

            Console.WriteLine(SmallNumber(number_1, number_2)); 


            Console.ReadKey();
        }
    }
}
