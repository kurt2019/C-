using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_7._4
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double UnknownTriangleAreaFormula()
        {
            double p = (A + B + C) * 2;
            double S = Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 4);
            return S;
        }

        public double UnknownTrianglePerimeterFormula()
        {
            double p = Math.Round(((A + B + C) / 2), 4);
            return p;
        }

        public void InfoPerimeterAndArea()
        {
            Console.WriteLine($"Необыкновенная площадь треугольника = {UnknownTriangleAreaFormula()}\n" +
                $"а также необыкновенный периметр треугольника = {UnknownTrianglePerimeterFormula()}");
        }



        public Triangle (double _A, double _B, double _C)
        {
            A = _A;
            B = _B;
            C = _C;
        }




    }





    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу, в которой создайте класс «Треугольник».В теле класса создайте три закрытых поля
            для описания сторон треугольника и три свойства для чтения и записи. Также в теле класса создайте 3 метода:
            1-й для расчета площади треугольника, формула для расчета S=√(p*(p-a)*(p-b)*(p-c) ), 
            где p - полупериметр треугольникаp=(a+b+c)/2,a, b, c – длины сторон треугольника, 
            2-й для расчета периметра треугольника, формула для расчета p=(a+b+c)/2 и 3-й для вывода информации
            о площади и периметре треугольника.Создайте конструктор, который в качестве аргументов приминимает
            стороны треугольника и инициализирует поля класса. В методе Main() создайте экземпляр класса «Треугольник»,
            задайте произвольное значение сторон треугольника и выведите на экран значение периметра и площади треугольника.
            */
            #endregion

            Triangle New = new Triangle(5, 10,10);
            Console.WriteLine(New.UnknownTriangleAreaFormula());

            New.InfoPerimeterAndArea();




            Console.ReadKey();
        }
    }
}
