using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПроверочныеЗадания_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for(; counter < 3; )
            {
                Console.WriteLine("Введите пин: ");
                string pin = Console.ReadLine();
                if (pin == "1111")
                {
                    Console.WriteLine("Пароль верный");
                    counter = 3;
                }
                else
                {
                    Console.WriteLine("Неверный пароль");
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine("Ваша карта заблокирована");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
