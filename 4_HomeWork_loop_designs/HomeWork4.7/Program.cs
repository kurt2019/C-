using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу,
            в которой создайте две целочисленные переменные и задайте им некоторые значения. Применяя
            технику вложенных циклов, нарисуйте прямоугольник из звездочек. Используйте значения ранее 
            созданных переменных для указания высоты и ширины прямоугольника 
            */

            for (int i = 1; i < 10; i++)
            {
                for (int k = 0; k <= 30; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }

            Console.ReadKey();
        }
    }
}
