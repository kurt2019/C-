using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Для укр мови */
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int x = 10, y = 12, z = 3;
            Console.WriteLine("Результати виводим, а як інакше\n");
            x += y - x++ * z;
            Console.WriteLine($" x += y - x++ * z  x = {x}\n");
            z = --x - y * 5;
            Console.WriteLine($" z = --x - y * 5  z = {z}\n");
            y /= x + 5 % z;
            Console.WriteLine($" y /= x + 5 % z  y = {y}\n");
            z = x++ + y * 5;
            Console.WriteLine($" z = x++ + y * 5  z = {z}\n");
            x = y - x++ * z;
            Console.WriteLine($" x = y - x++ * z  x = {x}\n");



            Console.ReadKey();
        }
    }
}
