using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5
{
    class Program
    {
        /// <summary>
        /// Average of 3 numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns> mean </returns>
        static double Mean(double a, double b, double c)
        {
             double mean = (a + b + c) / 3;
             return mean;
        }
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу в которой создайте метод, который принимает в качестве
            параметров три целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов.
            */

            Console.WriteLine("Введите 3 значения для вычисления среднего их значения\n");

            Console.WriteLine("Введите первое число:");
            int number_1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number_2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int number_3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Результат вичислений = {Math.Round(Mean(number_1, number_2, number_3), 3)}");


            Console.ReadKey();
        }
    }
}
