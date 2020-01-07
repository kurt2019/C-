using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_array_6._4
{
    class Program
    {
        static string WordBackwards(string word)
        {
            char[] back = word.ToCharArray();
            for (int i = back.Length - 1; i >= 0; i--)
            {
                Console.Write($"{back[i]}");
            }
            return Convert.ToString(back);
        }

        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте метод, который в качестве параметра 
            принимает слово, а возвращает тоже слово, но с измененным порядком букв в слове на обратный.
            */
            #endregion

            Console.WriteLine("Введите слово которое будет преобразовано в обратном порядке");
            string word = Console.ReadLine();
            WordBackwards(word);

            Console.ReadKey();
        }
    }
}
