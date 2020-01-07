using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._4
{
    class XMLHandler : AbstractHandler
    {
        override public void Open(string name)
        {
            Console.WriteLine($"Открить документ {name}.xml");
        }

        virtual public void Create(string name)
        {
            Console.WriteLine($"Создать документ {name}.xml");
        }

        public void Chenge(string name)
        {
            Console.WriteLine($"Изменить документ {name}.xml");
        }

        override public void Save(string name)
        {
            Console.WriteLine($"Сохранить документ {name}.xml");
        }
    }
}
