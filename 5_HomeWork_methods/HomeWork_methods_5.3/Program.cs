using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5._3
{
    class Program
    {
        /// <summary>
        ///  Calculating how old
        /// </summary>
        /// <param name="a"></param>
        /// <returns> year </returns>
        static string difference(int a)
        {
            if ( a > 100)
            {
               return "Та прям таки, больше 100 СЕРЙОЗНО?!)\n Предоставь документи";
            }
            else if (a < 0)
            {
                return "Ну не может так быть)";
            }
            else
            {
                int difference = DateTime.Now.Year - a;
                return $"Ваш полный возраст = {difference} лет";
            }
        }


        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте метод, который принимает в качестве
            аргумента год рождения пользователя и возвращает его полный возраст. 
            */
            Console.WriteLine("Введите ваш год рождения:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(difference(year));

            Console.ReadKey();
        }
    }
}
