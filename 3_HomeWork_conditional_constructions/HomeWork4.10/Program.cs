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
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу расчета начисления премий сотрудникам. Премии рассчитываются
            согласно выслуге лет. Если выслуга до 5 лет, премия составляет 10% от заработной платы.
            Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы.
            Если выслуга от 10 лет (включительно) до 15 лет, премия составляет 25% от заработной платы.
            Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной платы.
            Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной платы. 
            Если выслуга от 25 лет (включительно) и более, премия составляет 50% от заработной платы.
            Результаты расчета, выведите на экран. 
            */
            double result;

            Console.WriteLine("Введите заработную плату сотрудника:");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите выслугу лет сотрудника, для расчета премий:");
            int years_of_service = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (years_of_service < 5)
            {
                result = Math.Round((salary * 10 / 100), 2);
                Console.WriteLine($"Премия 10% от зароботной платы = {result}");
            }

            else if (years_of_service >= 5 && years_of_service < 10)
            {
                result = Math.Round((salary * 15 / 100), 2); 
                Console.WriteLine($"Премия 15% от зароботной платы = {result}");
            }

            else if (years_of_service >= 10 && years_of_service < 15)
            {
                result = Math.Round((salary * 25 / 100), 2);
                Console.WriteLine($"Премия 25% от зароботной платы = {result}");
            }

            else if (years_of_service >= 15 && years_of_service < 20)
            {
                result = Math.Round((salary * 35 / 100), 2);
                Console.WriteLine($"Премия 35% от зароботной платы = {result}");
            }

            else if (years_of_service >= 20 && years_of_service < 25)
            {
                result = Math.Round((salary * 45 / 100), 2);
                Console.WriteLine($"Премия 45% от зароботной платы = {result}");
            }
            else
            {
                result = Math.Round((salary * 50 / 100), 2);
                Console.WriteLine($"Премия 50% от зароботной платы = {result}");
            }



            Console.ReadKey();
        }
    }
}
