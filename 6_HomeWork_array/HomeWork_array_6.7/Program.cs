using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_array_6._7
{
    class Program
    {
        static int[] Method(int[] array, int index, int count)
        {
            int[] subArray = new int[array.Length];
            for (int i = 0, j = 0; i < array.Length; ++i)
            {
                if (i >= index)
                {
                    j++;
                    if (j <= count)
                    {
                        subArray[i - 1] = array[i];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return subArray;
        }


        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте метод, который в качестве аргументов принимает: 
            1)целочисленный массив(int [] array), 
            2)целочисленный индекс(int index), 
            3)количество элементов (int count), 
            возвращает целочисленный массив элементов(int []subArray). 
            Метод возвращает часть полученного в качестве аргумента массива, 
            начиная с позиции указанной в аргументе index, размерностью, которая соответствует значению аргумента count.
            */
            #endregion
            int[] arrray_main = new int[10];
            for (int i = 1; i <= arrray_main.Length - 1; ++i)
            {
                arrray_main[i] = i;
            }

            int[] trueArray = Method(arrray_main, 4, 4);
            foreach (int element in trueArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

