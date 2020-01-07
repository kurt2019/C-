using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, которая будет рассчитывать процент скидки в зависимости от
            количества купленного товара. Если куплено больше 3 единиц товара, тогда скидка
            должна быть 10 процентов от общей суммы, если же количество больше 3 и меньше 7,
            то 20процентов от общей суммы, иначе, если больше 7 то 25 процентов от общей суммы. 
            Цену товара и купленное количество товара пользователь должен задавать вводом с консонли.  
            */

            double price;
            int count;

            Console.WriteLine("Введите цену товара:");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("введите количество товара:");
            count = Convert.ToInt32(Console.ReadLine());

            if (count <3)
            {
                double result = price * count * 10 / 100;
                Console.WriteLine($"Сума скидки {result} , a скидка 10%");
            }
            else if (3 < count && count < 7)
            {
                double result = price * count * 20 / 100;
                Console.WriteLine($"Сума скидки {result} , a скидка 20%");
            }
            else if (count > 7)
            {
                double result = price * count * 25 / 100;
                Console.WriteLine($"Сума скидки {result} , a скидка 25%");
            }
            else
            {
                Console.WriteLine("Что то пошло не так");
            }


            Console.ReadKey();
        }
    }
}
