using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_HomeWork_Inheritance_polymorphism
{
    class Tail // Хвост
    {
        public int Lenght { get; set; }

        public string Name { get; set; }

        public Tail(int lenght, string name)
        {
            Lenght = lenght;
            Name = name;
        }
    }

    class TailedAnimal // Хвостатое животное 
    {
        public Tail TailAnimal { get; set; }

        public string Color { get; set; }

        public int Age { get; set; }

        public TailedAnimal(Tail tail, string color, int age)
        {
            TailAnimal = tail;
            Color = color;
            Age = age;
        }
    }

    class Dog : TailedAnimal
    {
        public string Nickname { get; set; }

        public Dog(Tail tail, string color, int age, string nickname)
            : base(tail, color, age)
        {
            Nickname = nickname;
        }

        public void Display()
        {
            Console.WriteLine($"Имя = {Nickname}, Цвет = {Color}, Возраст = {Age}, Длина хвоста = {TailAnimal.Lenght}");
        }
    }




    class Program
    {
        static void Main()
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу, в которой создайте класс хвост, который содержит в себе полядлину
            хвоста типа intи вид хвоста типаstring, создать свойства доступа и конструктор пользовательский класса.
            Создать класс хвостатое животное, содержащий хвост,цвет(строка),возраст.
            Определить public-производный класс собака, имеющий дополнительный параметр-кличку (строка). 
            В классе собака создать метод для отображения полной информации о собаке. 
            */
            #endregion

            Tail tail = new Tail(10, "tail");
            Dog dog = new Dog(tail, "red", 5, "dog");
            dog.Display();

            Console.ReadLine();
        }
    }
}
