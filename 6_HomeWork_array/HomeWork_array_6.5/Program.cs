using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_array_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой пользователь вводит прибыль фирмы за 12 месяцев.
            После чего пользователь вводит диапазон (например, 3 и 6 – поиск между 3-м и 6-м месяцем).
            Необходимо определить месяц, в котором прибыль была максимальна и месяц,
            в котором прибыль была минимальна с учетом выбранного диапазона.
            */
            #endregion

            string[] month = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };

            Console.WriteLine("Введите прибыль фирмы за каждый месяц из 12:");
            double[] money_of_month = new double[12];

            for (int i = 0; i < money_of_month.Length; i++)
            {
                Console.WriteLine($"Введите прибиль за {month[i]} месяць");
                money_of_month[i] = Convert.ToDouble(Console.ReadLine());
            }



            Console.WriteLine("Введите начальний месяц из диапазона:");
            int start = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Введите конечный месяц из диапазона:");
            int end = Convert.ToInt16(Console.ReadLine());

            int iteration_2 = 0; // Итерация
            int iteration = 0;   // Итерация
            double min = money_of_month[0];  // Минимальний элемент
            double max = money_of_month[0];  // максимальный элемент
            for (int i = start; i < end; ++i)
            {
                if (money_of_month[i] > max)
                {
                    max = money_of_month[i];
                }
                if (money_of_month[i] < min)
                {
                    min = money_of_month[i];
                }
            }

            for (int i = 0; i < money_of_month.Length; i++)
            {
                if (money_of_month[i] == min)
                {
                    break;
                }
                iteration_2++;
            }

            for (int i = 0; i < money_of_month.Length; i++)
            {
                if (money_of_month[i] == max)
                {
                    break;
                }
                iteration++;
            }

            Console.WriteLine($"Максимальный прибыль = {max} в {month[iteration]}");
            Console.WriteLine($"Минимальная  прибыль = {min} в {month[iteration_2]}");


            Console.ReadKey();
        }
    }
}
