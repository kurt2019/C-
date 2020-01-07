using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_method_5._4
{
    class Program
    {
        static double Calculator(int a, char sign, int b)
        {
            if (sign == '+')
            {
                double result = a + b;
                return result;
            }
            else if (sign == '-')
            {
                double result = a - b;
                return result;
            }
            else if (sign == '*')
            {
                double result = a * b;
                return result;
            }
            else if (sign == '/')
            {
                if (a == 0 || b == 0)
                {
                    return 010101;
                }
                else
                {
                    double result = a / b;
                    return result;
                }
            }
            else if (sign == '%')
            {
                double result = a % b;
                return result;
            }
            else
            {
                return 1;
            }
        }




        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу консольный калькулятор. В данной программе должны быть 
            четыре метода, метод для сложения, вычитания, умножения и деления. 
            Каждый из методов должен принимать 2 целочисленных аргумента и выполнять соответствующею действие.
            Метод для деления должен выполнять проверку деления на ноль. Также необходимо предоставить пользователю 
            возможность вводить знак арифметической операции, в зависимости от знака вызывать соответствующий метод. 
            Также пользователю необходимо предоставить возможность вводит значения аргументов.  
            */

            Console.WriteLine("Введите числа и арифметический символ для подсчета результата\n");

            Console.WriteLine("Введите первое число:");
            int number_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите арифметический знак:");
            char sign = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.WriteLine("Введите второе число:");
            int number_2 = Convert.ToInt32(Console.ReadLine());

            double result = Calculator(number_1, sign, number_2);
            if (result == 010101)
            {
                Console.WriteLine("На 0 делить нельзя!");
            }
            else
            {
                Console.WriteLine(result);
            }



            Console.ReadKey();
        }
    }
}
