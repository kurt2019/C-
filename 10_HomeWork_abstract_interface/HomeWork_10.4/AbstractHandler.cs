using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._4
{
    abstract class AbstractHandler
    {
        abstract public void Open(string name);

        virtual public void Create()
        {
            Console.WriteLine("Create");
        }

        public void Chenge()
        {
            Console.WriteLine("Chenge");
        }

        abstract public void Save(string name);
    }
}
