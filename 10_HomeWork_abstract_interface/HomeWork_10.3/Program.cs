using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте базовый абстрактный класс Document (документ), в котором создайте три метода void
            Headline (Заголовок), DocumentСontent (Содержимое документ), Footer (подвал документа).
            Реализуйте конкретный класс, который наследуется от производного класса Document, 
            в теле класса реализуйте все методы абстрактного класса. 
            (Реализация может заключатся в простом выводе информации о том какая это часть документа.) 
            */
            #endregion
            ThisClass thisClass = new ThisClass();
            thisClass.Headline();
            thisClass.DocumentСontent();
            thisClass.Footer();


            Console.ReadKey();
        }
    }
}
