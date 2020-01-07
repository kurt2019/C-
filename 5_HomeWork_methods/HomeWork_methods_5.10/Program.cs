using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5._10
{
    class Program
    {
        static void DischargeNumber(string a)
        {
            int result = a.Length;
            Console.WriteLine($"Количество розрядов числа = {result}");
        }

        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу, в которой создайте метод, который в качестве аргумента
            принимает целое число и определяет количество разрядов данного числа. 
            Пользователь должен иметь возможность вводит число с клавиатуры. 
            */

            Console.WriteLine("Введите число для определения его разрядности:");
            string discharge = Console.ReadLine();

            DischargeNumber(discharge);


            Console.ReadKey();
        }
    }
}
