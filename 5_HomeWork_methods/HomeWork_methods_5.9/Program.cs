using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5._9
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int SumNumber(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else if (number == 0)
            {
                return 0;
            }
            else
            {
                return number + SumNumber(number - 1);
            }
        }

        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу, которая будет вычислять сумму цифр числа N. Число N
            пользователь должен вводить с клавиатуры. При решении этой задачи нельзя
            использовать строки, списки, массивы (ну и циклы, разумеется). (Использовать рекурсию)
            */

            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SumNumber(number));


            Console.ReadKey();
        }
    }
}
