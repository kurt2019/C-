using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5._8
{
    class Program
    {
        /// <summary>
        /// Не нашел способ как получить вывод чисел без использования стартового значения вне метода 
        /// </summary>
        /// <param name="user_number"></param>
        /// <param name="first"></param>
        static void Recursion(int user_number, int first)
        {
            if (user_number == 0)
            {
                Console.WriteLine("Задана неверная точка отсчета, на 0 и остановимся");
            }
            else if (user_number > first)
            {
                first++;
                Console.WriteLine(first);
                if (first != user_number)
                {
                    
                    Recursion(user_number, first);
                }
            }
            else
            {
                Console.WriteLine("Что то пошло не так");
            }
        }

        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу, в которой создайте метод, который выведет все числа
            от 1 до N. N – число которое пользователь вводит с клавиатуры. (Использовать рекурсию)
            */

            /* Не нашел способ как получить вывод чисел без использования стартового значения вне метода */
            Console.WriteLine("Введите число к которому считать:");
            int number = Convert.ToInt32(Console.ReadLine());
            int one = 0;
            Recursion(number, one);

            Console.ReadKey();
        }
    }
}
