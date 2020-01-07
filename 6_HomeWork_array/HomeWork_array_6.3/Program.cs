using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_array_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте два строковых массива с именами
            A и B (размерностью 4 элемента). Массив A заполняется в цикле пользователем.
            Получить результирующий массив B, обратный к исходному массиву A
            (элементы массива B идут в обратном порядке по отношению к массиву A).
            */
            #endregion

            string[] A = new string[4];
            string[] B = new string[4];
            Console.WriteLine("Заполните массив:");
            for (int i = 0; i < 4; i++)
            {
                A[i] = Console.ReadLine();
            }

            Console.WriteLine("\nВ обычном порядке\n");
            foreach (string item in A)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\nВ обратном порядке\n");
            for (int i = B.Length - 1; i >= 0; i--)
            {
                B[i] = A[i];
                Console.Write($"{A[i]} ");
            }



            Console.ReadKey();
        }
    }
}
