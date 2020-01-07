using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_7._2
{
    class Kitten
    {
        private string name;
        private string wool_color;
        private string eye_color;
        private int years;

        public string Name {get; set;}
        public string Wool_color { get; set; }
        public string Eye_color { get; set; }
        public int Years { get; set; }

        public void Meow(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                Console.Write("Meow");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу в которой создайте класс «Котенок».
            В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз.
            Для каждого поля, создать свойство с двумя методами доступа. Также в теле класса создайте метод,
            который будет выводить на консоль «Мяу», метод должен принимать один аргумент – количество «Мяу» котенка,
            выводить «Мяу» соответствующее количество раз. В методе Main() создайте экземпляр класса «Котенок»,
            присвойте всем полям значение через свойства доступа, а также вызовите метод с помощью которого
            котенок говорит «Мяу», в качестве аргумента метода передайте 3.
            */
            #endregion

            Kitten Cat = new Kitten();
            Cat.Name = "Тося";
            Cat.Years = 2;
            Cat.Wool_color = "Серо-черный";
            Cat.Eye_color = "Коричневый";

            Console.WriteLine("Введите количество раз сколько котенок мяукает:");
            int count = Convert.ToInt32(Console.ReadLine());
            Cat.Meow(count);



            Console.ReadKey();
        }
    }
}
