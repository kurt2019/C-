using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу, в которой создайте класс AbstractHandler. В теле класса создать 
            методы void Open(), void Create(), void Chenge(), void Save().
            Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
            Написать логику, которая будет выполнять определение документа и для каждого формата должны быть методы 
            открытия, создания, редактирования, сохранения определенного формата документа.  
            */
            #endregion
            Console.WriteLine("Введите название документа:");
            string nameDoc = Console.ReadLine();
            Console.WriteLine("Введите формат документа:");
            string formatDoc = Console.ReadLine();

            byte lol = 100;

            if (formatDoc == "txt" || formatDoc == "TXT" || formatDoc == "Txt")
            {
                TXTHandler tXTHandler = new TXTHandler();
                tXTHandler.Open(nameDoc);
                tXTHandler.Create(nameDoc);
                tXTHandler.Chenge(nameDoc);
                tXTHandler.Save(nameDoc);
            }
            else if (formatDoc == "xml" || formatDoc == "XML" || formatDoc == "Xml")
            {
                XMLHandler xMLHandler = new XMLHandler();
                xMLHandler.Open(nameDoc);
                xMLHandler.Create(nameDoc);
                xMLHandler.Chenge(nameDoc);
                xMLHandler.Save(nameDoc);
            }
            else if (formatDoc == "doc" || formatDoc == "Doc" || formatDoc == "Doc")
            {
                DOCHandler dOCHandler = new DOCHandler();
                dOCHandler.Open(nameDoc);
                dOCHandler.Create(nameDoc);
                dOCHandler.Chenge(nameDoc);
                dOCHandler.Save(nameDoc);
            }
            else
            {
                lol = 1;
                Console.WriteLine("Такой формат мне неизвестен!");
            }
            if (lol == 1)
            {
               
            }
            else
            {
                Console.WriteLine("\nПрограма может быть более правильная но здесь у нас есть только консоль, поэтому такая логика)))");

            }

 
            Console.ReadKey();
        }
    }
}
