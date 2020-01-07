using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, в которой пользователь вводит целое число. Программа в
            свою очередь должна ответить, четным или нечетным является это число, делится ли оно на 3 и делится ли оно на 6. 
            */

            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            /* Блок проверок */
            int result = number % 2;
            int result_on_3 = number % 3;
            int result_on_6 = number % 6;



            if (result == 0)
            {
                Console.WriteLine("Число четное");
                if (result_on_6 == 0)
                {
                    Console.WriteLine("И делитса на 6");
                    if (result_on_3 == 0)
                    {
                        Console.WriteLine("Число также делитса на 3");
                    }
                    else
                    {
                        Console.WriteLine("Число также нe делитса на 3");
                    }
                }
            }
            else if (result != 0)
            {
                Console.WriteLine("Число нечетное");
                if (result_on_3 == 0)
                {
                    Console.WriteLine("Число также делитса на 3");
                    if (result_on_6 == 0)
                    {
                        Console.WriteLine("Число также делитса на 6");
                    }
                    else
                    {
                        Console.WriteLine("И не делитса на 6");
                    }
                }
                else
                {
                    Console.WriteLine("Число также нe делитса на 3");
                    Console.WriteLine("И не делитса на 6");
                }
            }






            Console.ReadKey();
        }
    }
}
