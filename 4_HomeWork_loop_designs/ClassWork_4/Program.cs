using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, которая будет выводить  на экран числа от 1 до 5.  
            Написать три варианта реализации (while, do...while, for).
            */
            int number = 0;
            while (number <= 5)
            {
                Console.WriteLine($"while Наше число = {number}");
                number++;
            }
            Console.WriteLine("\n");

            int lol = 0;
            do
            {
                Console.WriteLine($"do while Наше число = {lol}");
                lol++;
            }
            while (lol <= 5);
            Console.WriteLine("\n");

            for (int num = 0; num <= 5; num++)
            {
                Console.WriteLine($"for Наше число = {num}");
            }

            Console.ReadKey();
        }
    }
}
