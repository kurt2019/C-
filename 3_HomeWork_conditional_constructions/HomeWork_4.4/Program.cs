using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число:");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number % 2;
            int result_3 = number % 3;
            int result_6 = number % 6;




            if (result == 0)
            {
                Console.WriteLine("Число четное");
            }
            else if (result_3 == 0)
            {
                Console.WriteLine("Число делитса на 3");
            }
            else if (result_6 == 0)
            {
                Console.WriteLine("Число делитса на 6");
            }
                /* Треба доробити   */




            Console.ReadKey();
        }
    }
}
