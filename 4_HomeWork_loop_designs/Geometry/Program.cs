using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int number_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number_2 = Convert.ToInt32(Console.ReadLine());

            int stub = 1;



            Console.WriteLine("Треугольник под 90%");
            for (int i = 0; i < number_1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int number_4 = number_2;

            Console.WriteLine("Равносторонний");
            for (int i = 0; i < number_1; i++)
            {
                for (int j = 0; j < number_4; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < stub; k++)
                {
                    Console.Write("*");
                }
                number_4 -= 1;
                stub += 2;
                Console.WriteLine();
            }

            int number_3 = 1;


            Console.WriteLine("Ромб");
            for (int i = 0; i < (number_1 + number_1 + 1); i++)
            {
                if (i < number_1)
                {
                    for (int j = 0; j < number_2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < number_3; k++)
                    {
                        Console.Write("*");
                    }
                    number_2 -= 1;
                    number_3 += 2;
                    Console.WriteLine();
                }
                    else
                {
                    for (int j = 0; j < number_2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < number_3; k++)
                    {
                        Console.Write("*");
                    }
                    number_2 += 1;
                    number_3 -= 2;
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
