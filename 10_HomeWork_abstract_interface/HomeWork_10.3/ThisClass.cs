using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._3
{
    class ThisClass : Document
    {
        public override void Headline()
        {
            Console.WriteLine("Заголовок");
        }
        public override void DocumentСontent()
        {
            Console.WriteLine("Содержимое документ");
        }
        public override void Footer()
        {
            Console.WriteLine("Подвал документа");
        }
    }
}
