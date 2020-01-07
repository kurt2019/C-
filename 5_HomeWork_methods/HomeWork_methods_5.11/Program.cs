using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_methods_5._11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application. Представьте,
            что вы реализуете программу для банка, которая помогает определить, погасил ли клиент кредит или нет.
            Допустим, ежемесячная сумма платежа должна составлять 100 грн. Клиент должен выполнить 7 платежей,
            но может платить реже большими суммами. Т.е., может двумя платежами по 300 и 400 грн. Закрыть весь долг. 
            Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банка. 
            Метод выводит на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга). 
            */
            Console.WriteLine("Введите суму платежа:");
            int sum_economist = Convert.ToInt32(Console.ReadLine());

            Bank(sum_economist);

            Console.ReadKey();
        }

        static void Bank(int sum_economist)
        {
            int oll_sum = 700;
            int min_pay = 100;
            int result;

            if (sum_economist < min_pay)
            {
                Console.WriteLine("Ошибочка минимальный платеж 100 грн");
            }
            else if (sum_economist > 100)
            {
                result = oll_sum - sum_economist;
                if (result == 0)
                {
                    Console.WriteLine($"Сума задолжености = {result} грн,\nВаша сума оплаты = {sum_economist} грн, долг отсутствует");
                }
                else if (result > 0)
                {
                    Console.WriteLine($"Сума задолжености = {result} грн,\nВаша сума оплаты = {sum_economist} грн, вы должни оплатить еще = {result} грн");
                }
                else if (sum_economist > oll_sum)
                {
                    result = sum_economist - oll_sum;
                    Console.WriteLine($"Вы погасили кредит и зачислили себе на счет = {result} грн,\n" +
                        $"Ваша сума оплаты = {sum_economist} грн, долг отсутствует");
                }
            }
        }
    }
}