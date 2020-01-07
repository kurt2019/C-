using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_array_6._8
{
    class Program
    {
        static int[] insertElement(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = value;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            return newArray;
        }

        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.Создайте программу,
            в которой создайте метод, который будет выполнять увеличение длины массива переданного в качестве аргумента,
            на 1 элемент. Метод, должен принимает два аргумента, первый аргумент - типа int[] array, 
            второй аргумент - типа int value. В теле метода реализуйте возможность добавления 
            второго аргумента метода в массив по индексу – 0, при этом длина нового массива, должна увеличиться на 1 элемент,
            а элементы получаемого массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1. 
            */
            #endregion

            int[] array_main = new int[10];
            for (int i = 0; i <= array_main.Length - 1; ++i)
            {
                array_main[i] = i;
                Console.Write($"{array_main[i]} ");
            }

            Console.WriteLine("\nВведите начальное значение массива:");
            int value = Convert.ToInt32(Console.ReadLine());

            int[] newArray = insertElement(array_main, value);

            foreach (int element in newArray)
            {
                Console.Write($"{element} ");
            }

            Console.ReadKey();
        }
    }
}
