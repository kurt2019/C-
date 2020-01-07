using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8._3
{
    class ClassRoom
    {
        public Pupil[] Pupils { get; set; }

        // Конструкторы для создания 
        public ClassRoom(Pupil pupil0, Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            Pupils = new Pupil[] { pupil0, pupil1, pupil2, pupil3 };
        }
        public ClassRoom(Pupil pupil0, Pupil pupil1, Pupil pupil2)
        {
            Pupils = new Pupil[] { pupil0, pupil1, pupil2 };
        }
        public ClassRoom(Pupil pupil0, Pupil pupil1)
        {
            Pupils = new Pupil[] { pupil0, pupil1 };
        }

        public void ShowInfo()
        {
            foreach (Pupil pupil in Pupils)
            {
                    Console.WriteLine("\n");
                    Console.WriteLine($"Типчик: {pupil.Name}");
                    pupil.Study();
                    pupil.Read();
                    pupil.Write();
                    pupil.Relax();
            }
            Console.WriteLine("\n\n");
        }
    }

    class Pupil
    {

        public string Name { get; set; }

        public virtual void Study()
        {

        }

        public virtual void Read()
        {

        }

        public virtual void Write()
        {

        }

        public virtual void Relax()
        {

        }
    }

    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name)
        {
            Name = name ;
        }

        public override void Study()
        {
            Console.WriteLine("Изучаю на 12");
        }

        public override void Read()
        {
            Console.WriteLine("Читаю просто как зверь на 12");
        }

        public override void Write()
        {
            Console.WriteLine("Пишу и не думаю поэтому 12");
        }

        public override void Relax()
        {
            Console.WriteLine("Не отдыхаю, я ж задрот");
        }
    }


    class GoodPupil : Pupil
    {
        public GoodPupil(string name)
        {
            Name = name;
        }

        public override void Study()
        {
            Console.WriteLine("Красавчик знаю меру, результат 7-9");
        }

        public override void Read()
        {
            Console.WriteLine("Красавчик в голос не очень, а так норм 6-8");
        }

        public override void Write()
        {
            Console.WriteLine("Ну пока на одном языке, а потом и 3 можно будет, 7-9");
        }

        public override void Relax()
        {
            Console.WriteLine("Все четко!");
        }
    }

    class BadPupil : Pupil
    {
        public BadPupil(string name)
        {
            Name = name;
        }

        public override void Study()
        {
            Console.WriteLine("А зачем та учеба, пойду пивка попью с пацанами в падике 3-6");
        }

        public override void Read()
        {
            Console.WriteLine("А зачем читать можно в телике послушать 3-6");
        }

        public override void Write()
        {
            Console.WriteLine("Та Google исправит, мне то зачем 3-5");
        }

        public override void Relax()
        {
            Console.WriteLine("Житуха это оддих, зачем напрягаться в молодости, еще наработаю грузчиком");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Требуется: Создать класс, представляющий учебный класс ClassRoom. Создайте класс ученик Pupil.
            В теле класса создайте методы void Study(), void Read(), void Write(), void Relax(). 
            Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от базового класса Pupil
            и переопределите каждый из методов, в зависимости от успеваемости ученика.
            Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
            Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
            Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать. 
            */
            #endregion
            Console.WriteLine("Градация успеваемости начинается с 1 до 12 как в школе.");

            GoodPupil goodPupilOne = new GoodPupil("Stepka");
            ExcelentPupil excelentPupilOne = new ExcelentPupil("Botan");
            ExcelentPupil excelentPupilTwo = new ExcelentPupil("Dzamshut");
            BadPupil badPupilOne = new BadPupil("Dima");

            ClassRoom classRoom = new ClassRoom(goodPupilOne, excelentPupilOne, excelentPupilTwo, badPupilOne);
            classRoom.ShowInfo();

            Console.ReadKey();
        }
    }
}


