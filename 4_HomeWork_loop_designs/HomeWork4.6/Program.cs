using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу, которая поможет первокласнику Пети, у которого  m рублей.
            Мороженое стоит k рублей. Петя решил наесться досыта мороженого, для этого он
            покупал по одному мороженому и съедал его до тех пор, пока ему хватало денег.
            Как Пете узнать, сколько денег останется у него в конце концов? учтите, что петя
            делить еще не умеет, а умеет только вычитать и складывать. сколько мороженых он может съесть?. 
            */

            Console.WriteLine("Введите суму голди которая есть у Пети:");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите цену мороженого:");
            double k =  Convert.ToDouble(Console.ReadLine());

            while (m > k)
            {
                m -= k;
            }
            Console.WriteLine(m);

            Console.ReadKey();
        }
    }
}
