using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПроверочныеЗадания
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя VisualStudio, создайте проект по шаблону ConsoleApplication.
            Напишите программу, которая находит сумму  1+2+3+…+n, где число n вводится пользователем с клавиатуры.
            */

            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for (int i = 1; i <= number; i++)
            {
                result += i;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
