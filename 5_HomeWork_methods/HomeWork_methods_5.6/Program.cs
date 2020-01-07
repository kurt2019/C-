using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5._6
{
    class Program
    {
        static void Multiplication(ref int a, ref int b, ref int c)
        {
            a *= 10;
            b *= 10;
            c *= 10;
        }


        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу, в которой создайте метод, который принимает в качестве параметров
            три целочисленных значения и возвращает значение каждого аргумента, умноженного на 10.
            (Использовать out и ref)
            */
            int number_1 = 0;
            int number_2 = 0;
            int number_3 = 0;
            Console.WriteLine("Введите 3 числа для дальнейшего их умножения на 10");
            Console.WriteLine("Введите первое число:");
            number_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            number_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            number_3 = Convert.ToInt32(Console.ReadLine());

            Multiplication(ref number_1, ref number_2, ref number_3);

            Console.WriteLine($"Значение переменных: {number_1} {number_2} {number_3}");





            Console.ReadKey();
        }
    }
}
