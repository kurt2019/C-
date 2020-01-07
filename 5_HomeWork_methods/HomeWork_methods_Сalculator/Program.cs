using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_Сalculator
{
    class Program
    {
        static double Calculator_sum(int a, int b)
        {
                double result;
                return result = a + b;
        }

        static double Calculator_minus(int a, int b)
        {
                double result;
                return result = a - b; 
        }

        static double Calculator_multiplication(int a, int b)
        {
            double result;
            return result = a * b;
        }

        static double Calculator_division(int a, int b)
        {
            double result;
            if (a == 0 || b == 0)
            {
                return 010101;
            }
            else
            {
                result = a / b;
                return result;
            } 
        }
        static double Calculator_modulo_division(int a, int b)
        {
            double result = a % b;
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа и арифметический символ для подсчета результата\n");

            Console.WriteLine("Введите первое число:");
            int number_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите арифметический знак:");
            char sign = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.WriteLine("Введите второе число:");
            int number_2 = Convert.ToInt32(Console.ReadLine());


            if (sign == '+')
            {
                Calculator_sum(number_1, number_2);
            }
            else if (sign == '-')
            {
                Calculator_minus(number_1, number_2);
            }
            else if (sign == '*')
            {
                Calculator_multiplication(number_1, number_2);
            }
            else if (sign == '%')
            {
                Calculator_modulo_division(number_1, number_2);
            }
            else if (sign == '/')
            {
                if (Calculator_division(number_1, number_2) == 010101)
                {
                    Console.WriteLine("На 0 делить нельзя!");
                }
                else
                {
                    Console.WriteLine(Calculator_division(number_1, number_2));
                }
            }
            else
            {
                Console.WriteLine("Что то пошло не так!");
            }



            Console.ReadKey();
        }
    }
}
