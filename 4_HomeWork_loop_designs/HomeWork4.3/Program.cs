using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Используя Visual Studio, создайте проект по шаблону Console Application.
             Напишите программу, в которой даны натуральные числа от 20 до 50.
             Вывести на консоль те из них, которые делятся на 3, но не делятся на 5.
            */

            int number;
            for (number = 20; number <= 50; number++)
            {
                int del_3 = number % 3;
                int del_5 = number % 5;

                if ((del_3 == 0) && (del_5 != 0))
                {
                    Console.WriteLine($"Такие значения = {number}");
                }
            }

            Console.ReadKey();
        }
    }
}
