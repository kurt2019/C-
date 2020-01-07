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
            Используя VisualStudio, создайте проект по шаблону Console Application. Напишите программу,
            которая решает квадратное уравнение. Пользователь должен ввести коэффициенты а, b и с квадратного
            уравнения ах2 + bх + с = 0. После чего программа должна вывести на экран все корни этого уравнения
            или сообщение о том, что их нет. Рассмотреть случаи когда дискриминант (D) квадратного уравнения > 0, когда D<0 и когда D = 0. 
            */
            Console.WriteLine("Введите коэффициенты a, b, c:");
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"В таком случае у нас получается:\n {a}*x2 + {b}*x + {c} = 0");
            Console.WriteLine();
              /*Формула дискриминанта
              Дискриминант D квадратного трёхчлена ax2 + bx + c   равен b2 - 4ac.
              Ссилка с формулой
              http://edu.glavsprav.ru/info/diskriminant/
              */

            int D = Convert.ToInt32(Math.Pow(b, 2) - 4 * a * c);

            /* D > 0 - уравнение имеет 2 различных вещественных корня; */
            if (D > 0)
            {
                int x1 = Convert.ToInt32((-b - Math.Sqrt(D)) / (2 * a));
                int x2 = Convert.ToInt32((-b + Math.Sqrt(D)) / (2 * a));
                Console.WriteLine($"Получилось 2 корня: x1 = {x1}, x2 = {x2}");
            }
            /* D = 0 - уравнение имеет 1 корень (или же 2 совпадающих вещественных корня) */
            else if (D == 0)
            {
                int x3 =(-b / (2 * a));
                Console.WriteLine($"Есле D = 0 то 1 корень которий равен: {x3}");
            }
            /* D < 0 - уравнение имеет 2 мнимых корня (т.е. вещественных корней нет) */
            else
            {
                Console.WriteLine("Опачки нужно звать профессора");
            }


            Console.ReadKey();

        }
    }
}
