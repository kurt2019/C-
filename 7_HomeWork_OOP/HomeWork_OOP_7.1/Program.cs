using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_7._1
{
    class Address
    {
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;
        private int index;

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string AllAdress()
        {
            return $"Страна: {country}, город: {city}, улица: {street},\nдом: {house}, квартира: {apartment}, индекс: {index}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу в которой создайте класс «Адрес». 
            В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
            Для каждого поля, создать свойство с двумя методами доступа. Также в классе необходимо
            создать метод для отображения информации про адрес. В методе Main() создайте экземпляр
            класса «Адрес», присвойте всем полям значение через свойства доступа, а также на 
            экземпляр класса вызовите метод, который выводит информацию про адрес.
            */
            #endregion
            Address Human = new Address();
            Human.Country = "Украина";
            Human.City = "Киев";
            Human.Street = "Рабочая";
            Human.House = 57;
            Human.Apartment = 13;
            Human.Index = 01001;
            Console.WriteLine(Human.AllAdress());

            Console.ReadKey();
        }
    }
}
