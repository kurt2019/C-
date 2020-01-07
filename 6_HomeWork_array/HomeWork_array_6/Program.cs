using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_array_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран все элементы массива.
            */
            #endregion
            int[] array = { 14, 88, 1488, 66, 55 };

            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }





            Console.ReadKey();
        }
    }
}
