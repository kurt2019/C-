using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу,  которая будет рассчитывать сумму вклада  в банк. Процентную 
            ставку, сумму и срок на которой положили вклад, должен вводить пользователь с клавиатуры. 
            */

            Console.WriteLine("Введите суму:");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процентную ставку на рік:");
            double percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите срок на которий делаете вклад:");
            double time = Convert.ToDouble(Console.ReadLine());

            #region formuls
            /* 
            S - начальний депозит + процентная ставка
            Sp – сумма процентов (доходов).
            I – годовая процентная ставка
            t – количество дней начисления процентов по привлеченному вкладу
            K – количество дней в календарном году (365 или 366)
            P – сумма привлеченных в депозит денежных средств.
            Формула суми процентов: 
            Sp = P * * I * t / 365 / 100
            
            Формула суми + суми процентов:
            S = P + P * I * t / 365 / 100
            */
            #endregion 

            double S = sum + sum * percent * time / 365 / 100 ;
            Console.WriteLine(Math.Round(S, 3));

            double Sp = sum * percent * time / 365 / 100;
            Console.WriteLine(Math.Round(Sp, 3));

            Console.ReadKey();
        }
    }
}
