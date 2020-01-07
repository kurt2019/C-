using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_array_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте массив размерностью в 5 элементов, 
            выведите на экран все элементы массива в обратном порядке.
            */
            #endregion

            int[] array = new int[5];
            /* Заполнение */
            for (int i = 0; i <= array.Length-1; i++)
            {
                array[i] = i; 
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }




            Console.ReadKey();
        }
    }
}
