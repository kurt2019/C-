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
            Напишите программу определения, попадает ли указанное пользователем число
            от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. 
            Если да, то укажите, в какой именно промежуток. Если пользователь указывает 
            число не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение. 
            */

            Console.WriteLine("Введите число в диапазоне от 0 до 100:");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number <= 14)
            {
                Console.WriteLine("Вы ввели число в диапазоне чисел 0 - 14");
            }
            else if (number > 14 && number <= 35)
            {
                Console.WriteLine("Вы ввели число в диапазоне чисел 15 - 35");
            }
            else if (number > 35 && number <= 50)
            {
                Console.WriteLine("Вы ввели число в диапазоне чисел 35 - 50");
            }
            else if (number >= 51 && number <= 100)
            {
                Console.WriteLine("Вы ввели число в диапазоне чисел 51 - 100");
            }
            else
            {
                Console.WriteLine("Вы ввели значение вне диапазона чисел");
            }



            Console.ReadKey();
        }
    }
}
