using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу,  в которой запросите пользователя ввести два числа A и B (A<B),
            если (A>B выведите соответствующее предупреждение) и выведите суму всех чисел расположенных
            между данными числами на экран. Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.
            */
            Console.WriteLine("Введите 2 числа, но учтите 2 число должно быть больше первого:\n");
            Console.WriteLine("Введите первое число:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (A > B)
            {
                Console.WriteLine("Вы ввели неверно значения");
            }
            else
            {
                for (int i = A; i < B; i++)
                {
                    if ((i % 2) != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
