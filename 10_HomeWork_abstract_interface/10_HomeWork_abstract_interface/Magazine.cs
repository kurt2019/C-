using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HomeWork_abstract_interface
{
    class Magazine : IPrintable
    {
        public IPrintable[] Printable { get; set; }

        // Конструктор принимает массив
        public Magazine(IPrintable[] PrintablesArray)
        {
            Printable = PrintablesArray;
        }

        public void Print()
        {
            foreach (IPrintable Printable in Printable)
            {

                Printable.Print();
            }
        }
        public void PrintMagazines(IPrintable[] printable)
        {
            foreach (IPrintable printableItem in printable)
            {
                if (printableItem is Journal)
                {
                    printableItem.Print();
                }
            }
        }

        public void PrintBook(IPrintable[] printable)
        {
            foreach (IPrintable printableItem in printable)
            {
                if (printableItem is Book)
                {
                    printableItem.Print();
                }
            }
        }
    }
}
