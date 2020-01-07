using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8._2
{
    abstract class Shape
    {
        protected double volume;

        public double Volume { get; set; }

        public virtual double GetVolume()
        {
            return Volume;
        }
    }

    class Pyramid : Shape
    {
        private double areaPiram;

        private double heightPiram;

        public double AreaPiram { get; set; }
        public double HeightPiram { get; set; }

        public override double GetVolume()
        {
            double pyramidVolume = Math.Round((1.0 / 3.0), 2) * AreaPiram * HeightPiram;
            return pyramidVolume;
        }

    }


    class Cylinder : Shape
    {
        private double radiusCil;

        private double heightCil;

        public double RadiusCil { get; set; }
        public double HeightCil { get; set; }

        public override double GetVolume()
        {
            double cylinderVolume = Math.Round((Math.PI * (RadiusCil * RadiusCil) * HeightCil), 2);
            return cylinderVolume;
        }
    }

    class Ball : Shape
    {
        private double radiusBall;
        public double RadiusBall { get; set; }

        public override double GetVolume()
        {
            double ballVolume = Math.Round((((double)4 / (double)3) * Math.PI * Math.Pow(RadiusBall, 3)), 2);
             return ballVolume; 
        }
    }

    class Box
    {
        private double drawerVolume;

        public double DrawerVolume { get; set; }

        public bool Add(Shape shape)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; ; i++)
            {
                if (shape.Volume < DrawerVolume)
                {
                    count++;
                    sum += shape.Volume; 
                    if (sum >= DrawerVolume)
                    { 
                        Console.WriteLine($"Эта фигура вмещается = {count} раз");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Эта фигуда не вмещается в коробку");
                    return false;
                }
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
            Создайте программу, в которой создайте базовый класс Shape (фигура), который содержит в себе
            поле типа double c именем Volume и метод типа double GetVolume()  который должен вернуть объём фигуры.
            Далее создайте классы: Pyramid (пирамида), Cylinder(цилиндр), Ball(шар), которые будут наследоваться от класса  Shape,
            реализуйте в каждомиз них метод для нахождения объёма. Создайте класс Box(ящик) – он является контейнером,
            может содержать в себе другие фигуры.  В классе Box создайте поле типа double с именем DrawerVolume (Объем ящика),
            поле должно хранить в себе объём ящика.  Далее в классе Box  создайте метод Аdd(),
            который  принимает на вход объекты типа Shape, и возвращает значение типа bool. 
            В классе Box реализуйте логику для добавления новых фигуры до тех пор, пока для них хватает места в Box 
            (будем считать только объём, игнорируя форму, например, мы переливаем жидкость). 
            Если места для добавления новой фигуры не хватает, то метод должен вернуть false. 
            */
            #endregion

            // Создание всех обєктов
            Pyramid pir = new Pyramid();
            Cylinder cili = new Cylinder();
            Ball ball = new Ball();
            Box box = new Box();
            box.DrawerVolume = 10000; // объем коробки

            // Заполнение элементов пирамиды
            pir.AreaPiram = 8;
            pir.HeightPiram = 12;
            pir.Volume = pir.GetVolume();

            // Заполнение элементов цилиндра
            cili.HeightCil = 10;
            cili.RadiusCil = 8;
            cili.Volume = cili.GetVolume();

            // Заполнение элементов шара
            ball.RadiusBall = 15;
            ball.Volume = ball.GetVolume();

            // Подставляем фигуру
            box.Add(cili);

            Console.ReadKey();
        }
    }
}
