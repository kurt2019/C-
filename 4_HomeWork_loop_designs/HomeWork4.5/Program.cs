using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, где пользователь вводит любое целое положительное число.
            А программа суммирует все числа от 1 до введенного пользователем числа.
            */

            Console.WriteLine("Введите число к которому програма будет сумировать");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Через for с инкрементом = {sum}\n");

            int minus_for = 0;

            for (int i = number; i != 0; i--)
            {
                minus_for += i;
            }
            Console.WriteLine($"Через for с декрементом = {minus_for}");

            Console.ReadKey();
        }
    }
}
