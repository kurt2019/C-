using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._4
{
    class DOCHandler : AbstractHandler
    {
        override public void Open(string name)
        {
            Console.WriteLine($"Открить документ {name}.doc");
        }

        virtual public void Create(string name)
        {
            Console.WriteLine($"Создать документ {name}.doc");
        }

        public void Chenge(string name)
        {
            Console.WriteLine($"Изменить документ {name}.doc");
        }

        override public void Save(string name)
        {
            Console.WriteLine($"Сохранить документ {name}.doc");
        }
    }
}
