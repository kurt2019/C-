using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, в которой создайте переменную min. Значение переменной должен 
            задавать пользователь, интервал допустимых значений 0 до 59, необходимо организовать 
            проверку на ввод допустимого интервала. Определите в какую четверть часа попадает 
            значение переменной (в первую, вторую, третью или четвертую). 
            */

            Console.WriteLine("Введите число от 0 до 59:");
            int min = Convert.ToInt32(Console.ReadLine());

            if (0 < min && min <= 15)
            {
                Console.WriteLine("Вы попали в 1-ю четверть");
            }
            else if (16 <= min && min <= 30)
            {
                Console.WriteLine("Вы попали в 2-ю четверть");
            }
            else if (31 <= min && min <= 45)
            {
                Console.WriteLine("Вы попали в 3-ю четверть");
            }
            else if (46 <= min && min <=59 )
            {
                Console.WriteLine("Вы попали в 4-ю четверть");
            }
            else
            {
                Console.WriteLine("Неа, не тот диапазон чисел");
            }


            Console.ReadKey();
        }
    }
}
