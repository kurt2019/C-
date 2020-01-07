using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HomeWork_abstract_interface
{
    class Book : IPrintable
    {
        public string type = "Книга";
        public string BookTitle { get; set; }

        public Book(string nameBook)
        {
            BookTitle = nameBook;
        }

        public void Print()
        {
            Console.WriteLine($"Название книги = {BookTitle}, тип напечатаного = {type}");
        }
    }
}
