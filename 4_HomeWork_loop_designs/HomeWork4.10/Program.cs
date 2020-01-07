using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, которая будет складывать, вычитать, умножать или делить два числа.
            Числа и знак операции вводятся пользователем. После выполнения вычисления программа не 
            должна завершаться, а должна запрашивать новые данные для вычислений. Завершение программы
            должно выполняться при вводе символа '0' в качестве знака операции. Если пользователь вводит 
            неверный знак (не '0', '+', '-', '*', '/'), то программа должна сообщать ему об ошибке и снова 
            запрашивать знак операции. Также сообщать пользователю о невозможности деления на ноль, если он ввел 0 в качестве делителя.             
            */

            Console.WriteLine("Что бы выйти с програми введите знак 0\n");

            start: Console.WriteLine("Введите первое число");
            int one = Convert.ToInt32(Console.ReadLine());

            Char: Console.WriteLine("Введите знак операции");
            char sign = Console.ReadKey().KeyChar;

            Console.WriteLine("\nВведите второе число");
            int two = Convert.ToInt32(Console.ReadLine());

            if (sign == '0')
            {
                Console.WriteLine("Закритие програми. Конец");
            }
            else if ( sign != '+' && sign != '-' && sign != '*' && sign != '/')
            {
                Console.WriteLine("Вы ввели неверное значение для знака операции");
                goto Char;
            }
            else
            {
                for (; ; )
                {
                    switch (sign)
                    {
                        case '+':
                            double sum = one + two;
                            Console.WriteLine($"Сума чисел = {sum}");
                            goto start;

                        case '-':
                            double minus = one - two;
                            Console.WriteLine($"Результат вычитания = {minus}");
                            goto start;

                        case '*':
                            double multiplication = one * two;
                            Console.WriteLine($"Результат умножения = {multiplication}");
                            goto start;

                        case '/':
                            if (one == 0 || two == 0)
                            {
                                Console.WriteLine("На 0 можно делить только в высшей математике");
                                Console.WriteLine("Вы хотите вийти (ex) или заново ввести значения (go)");
                                string ex_or_go = Console.ReadLine();
                                if (ex_or_go == "ex")
                                {
                                    Console.WriteLine("Конец");
                                    goto end;
                                }
                                else if (ex_or_go == "go")
                                {
                                    goto start;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели неверное значения условия!   Пока");
                                    goto end;
                                }
                            }
                            else
                            {
                                double division = one / two;
                                Console.WriteLine($"Результат деления = {division}");
                                goto start;
                            }

                        default:
                            Console.WriteLine("Что то пошло не так");
                            break;
                    }
                }
            }

            end: Console.ReadKey();
        }
    }
}
