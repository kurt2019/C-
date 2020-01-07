using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HomeWork_abstract_interface
{
    class Journal : IPrintable
    {
        public string type = "Журнальчик";
        public string JournalTitle { get; set; }

        public Journal(string nameMagazine)
        {
            JournalTitle = nameMagazine;
        }

        public void Print()
        {
            Console.WriteLine($"Название книги = {JournalTitle}, тип напечатаного = {type}");
        }
    }
}
