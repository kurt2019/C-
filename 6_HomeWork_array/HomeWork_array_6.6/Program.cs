using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_array_6._6
{
    class Program
    {
        static int MaxValue(int count)
        {
            Random random = new Random();
            int[] array = new int[count];
            int max = array[0];

            // Заполняем массив
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            // Находим максимальное
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int MinValue(int count)
        {
            Random random = new Random();
            int[] array = new int[count];

            // Заполняем массив
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }
            int min = array[0];

            // Находим минимальное
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static int AllSum(int count)
        {
            Random random = new Random();
            int[] array = new int[count];

            int sum = 0;
            // Заполняем массив
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static double ArithmeticMean(int count)
        {
            Random random = new Random();
            int[] array = new int[count];

            int sum = 0;
            // Заполняем массив
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double mean = sum / count;
            return mean;
        }

        static void OddNumbers(int count)
        {
            Random random = new Random();
            int[] array = new int[count];

            // Заполняем массив
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            foreach (int a in array)
            {
                if (a % 2 != 0)
                {
                    Console.Write($"{a} ");
                }
            }
        }

    static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте массив размера N элементов(размер массива задет пользователь),
            заполнить его произвольными целыми значениями.Вывести на экран: наибольшее значение массива,
            наименьшее значение массива, общую сумму всех элементов, среднее арифметическое всех элементов, 
            вывести все нечетные значения. 
            */
            #endregion

            Console.WriteLine("Введите количество елементов массива:");
            int count_array = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Максимальное значение = {MaxValue(count_array)}");

            Console.WriteLine($"Минимально значение = {MinValue(count_array)}");

            Console.WriteLine($"Сума значений массива = {AllSum(count_array)}");

            Console.Write("Bсе нечетные значения: "); OddNumbers(count_array);




            Console.ReadKey();
        }
    }
}
