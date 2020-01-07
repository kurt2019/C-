using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, которая выводит на экран столько элементов ряда Фибоначчи,
            сколько указал пользователь. Например, если на ввод поступило число 6, то вывод должен
            содержать шесть первых чисел ряда Фибоначчи: 1 2 3 5 8 13. (Числа Фибоначчи -  элементы
            числовой последовательности,  в которой первые два числа равны либо 1 и 1, либо 0 и 1,
            а каждое последующее число равно сумме двух предыдущих чисел, например 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89). 
            */
            
            Console.WriteLine("Введите число для ряда Фибоначчи?");
            int number = Convert.ToInt32(Console.ReadLine());

            int first = 1;
            Console.Write($" {first}");
            int second = 1;
            Console.Write($" {second}");
            int sum = 0;

            while (number >= sum)
                {
                    sum = first + second;
                    Console.Write($" {sum}");
                    first = second;
                    second = sum;
                }

            Console.ReadKey();
        }
    }
}
