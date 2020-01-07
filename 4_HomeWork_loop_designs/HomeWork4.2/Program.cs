using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, которая будет выводить на экран таблицу умножения на 3.
            */

            int number, number2 = 0, result;
            for( number = 3; number2 <= 10; number2++)
            {
                result = number * number2; 
                Console.WriteLine($"{number} * {number2} = {result}");
            }

            Console.ReadKey();
        }
    }
}
