using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HomeWork_abstract_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу, в которой создайте интерфейс Printable, содержащий метод void Print().
            Далее создайте класс Book, Journal(журанл) реализующий интерфейс Printable. Создайте класс Magazine,
            реализующий интерфейс Printable. После создайте массив типа Printable, который будет содержать книги и журналы
            и в цикле пройти по массиву и вызвать метод Print() для каждого объекта. 
            Создать метод PrintMagazines(Printable[] Printable) в классе Magazine, который выводит на консоль названия только журналов.
            Создать метод PrintBooks(Printable[] Printable) в классе Book, который выводит на консоль названия только книг.
            */
            #endregion

            Book book1 = new Book("С# 4.0");
            Book book2 = new Book("C# 5.0");
            Book book3 = new Book("C# 6.0");
            Book book4 = new Book("C# 7.0");
            Book book5 = new Book("C# 8.0");
            Journal magazine1 = new Journal("Журнал 1");
            Journal magazine2 = new Journal("Журнал 2");
            Journal magazine3 = new Journal("Журнал 3");
            Journal magazine4 = new Journal("Журнал 4");
            Journal magazine5 = new Journal("Журнал 5");

            IPrintable[] Printable = {
            book1, book2, book3, book4, book5,
            magazine1, magazine2, magazine3, magazine4, magazine5
            };

            Magazine magazine = new Magazine(Printable);
            magazine.Print();
            Console.WriteLine("\n");
            magazine.PrintBook(Printable);
            Console.WriteLine("\n");
            magazine.PrintMagazines(Printable);
            Console.ReadKey();
        }
    }
}
