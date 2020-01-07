using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5._7
{
    class Program
    {
        /// <summary>
        /// rectangle = Square And Perimeter
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> Square And Perimeter </returns>
        static string SquareAndPerimeter(double a, double b)
        {
            double perimeter = Math.Round(((a + b) * 2), 3);
            double square = Math.Round((a * b), 3);
            return $"Периметр прямоуголиника = {perimeter},\nа площадь = {square}";
        }

        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Написать программу, в которой создайте один метод, который будет вычислять 
            площадь и периметр прямоугольника. Сторони прямоугольника пользователь
            должен иметь возможность вводит с клавиатуры.
            */
            Console.WriteLine("Введите значения для прямоугольника");
            Console.WriteLine("Введите высоту");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(SquareAndPerimeter(width, height));

            Console.ReadKey();
        }
    }
}
