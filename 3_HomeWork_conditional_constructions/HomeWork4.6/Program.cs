using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя VisualStudio, создайте проект по шаблону Console Application.
            Напишите программу, которая определяет, является ли год високосным. 
            Пользователь вводит год. Программа должна вывести на экран ответ, является
            ли год високосным.Подсказка. Обычно каждый год, который делится на 4, — это
            високосный год, кроме лет столетий (делящихся на 100). Но среди последних год, делящийся на 400, также считается високосным. 
            */

            Console.WriteLine("Введите год которий о котором вы хотите узнать:");
            int year = Convert.ToInt32(Console.ReadLine());

            int bissextile = year % 4;
            int rare = year % 400;
            int exception = year % 100;
            

            if (bissextile == 0 && (exception != 0 || rare == 0))
            {
                Console.WriteLine($"{year} високосный год");
            }
            else
            {
                Console.WriteLine($"{year} не високосный год");
            }

            Console.ReadKey();
        }
    }
}
