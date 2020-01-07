using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Для укр мови */
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть висоту  циліндра:");
            double height_cylinder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Введіть радіус циліндра:");
            double radius_cylinder = Convert.ToInt32(Console.ReadLine());

            double V_Cylinder = Math.PI * Math.Pow(radius_cylinder, 2) * height_cylinder;
            double S_Cylinder = 2 * Math.PI * radius_cylinder * (radius_cylinder + height_cylinder);
            Console.WriteLine();
            Console.WriteLine($"Об'єм циліндра = {V_Cylinder}");
            Console.WriteLine($"Площа циліндра = {S_Cylinder}");

            Console.ReadKey();
        }
    }
}
