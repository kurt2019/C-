using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_7._5
{
    class Dot /*Point*/
    {
        private double x;
        private double y;
        private string name;

        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }

        public Dot(double _X, double _Y, string _Name)
        {
            X = _X;
            Y = _Y;
            Name = _Name;
        }
    }

    class Figure
    {
        public Dot[] Dots { get; set; }
        public Figure(Dot one, Dot two, Dot three)
        {
            Dots = new Dot[] { one, two, three };
        }
        // Перегружаем метод для квадрата
        public Figure(Dot one, Dot two, Dot three, Dot four)
        {
            Dots = new Dot[] { one, two, three, four };
        }


        public double Perimeter()
        {
            double per = 0;

            for (int i = 0; i < Dots.Length; i++)
            {
                per += Dis(i, i == Dots.Length - 1 ? 0 : i + 1);
            }
            return per;
        }

        public static double Dis(Dot a, Dot b)
        {
            return Math.Sqrt((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
        }

        public double Dis(int lol1, int lol2)
        {
            return Dis(Dots[lol1], Dots[lol2]);
        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу, в которой создайте класс «Точка» – для описания координат  точки на координатной прямой рис №1.
            В теле класса создайте следующиезакрытые поля:целочисленное поле для описания координаты точки X и целочисленное поле
            для описания координаты точки Y, а также строковое поле для имени точки.Создать три свойства с методами доступа get и set,
            а также конструктор класса, который будет инициализировать данные поля значениями аргументов. Далее создайте класс «Фигура».
            В теле класса фигура создайте одно поле типа масив «Точек»и одно строкове поле для имени фигуры и 2 конструктора,
            которые принимают 3 (треугольника) и 4 аргумента (четырехугольника).В теле класса «Фигура»создайте два метода: 
            1-й для расчета длиныстороны фигуры, метод должен принимать 2 аргумента типа «Точка»и возвращать длину стороны, 
            формула для расчета d=√(〖(x_2-x_1)〗^2+ 〖(y_2-y_1)〗^2 ) и метод для расчетапериметрафигуры (подсказка – в методе 
            циклом перебирать массив «Точек», пока в нем будут элементы, и рассчитывать длину стороны).
            В методе Main() создать и рассчитать периметр треугольника, квадрата, прямоугольника, точки выбрать произвольные.
            */
            #endregion

            //Treug
            Dot a1 = new Dot(9.25,  5.78, "A");
            Dot b1 = new Dot(15.45, 20.56, "B");
            Dot c1 = new Dot(6.0,   11.13, "C");

            Figure Treg = new Figure(a1, b1, c1);
            double tregPer = Treg.Perimeter();

            Console.WriteLine($"Периметр треугольника = {tregPer: 0.##}");

            //Rectagle
            Dot a2 = new Dot(10.0, 10.0, "A");
            Dot b2 = new Dot(20.0, 10.0, "C");
            Dot c2 = new Dot(20.0, 20.0, "B");
            Dot d2 = new Dot(10.0, 20.0, "D");

            Figure Rec = new Figure(a2, b2, c2, d2);
            double recPer = Rec.Perimeter();

            Console.WriteLine($"Периметр четырехугольника = {recPer: 0.##}");

            Console.ReadKey();
        }
    }
}
