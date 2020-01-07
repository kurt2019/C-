using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8._4
{
    class Person
    { 
        public int BirthYear { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // Конструктор основного класа
        public Person(int _birthYear, string _name, string _surname)
        {
            BirthYear = _birthYear;
            Name = _name;
            Surname = _surname;
        }
        // Выводим инфу про всех человек
        public override string ToString()
        {
            string info = $"Имя: {Name} , Фамилия: {Surname} , Год рождения: {BirthYear}";
            return info;
        }
    }

    class Student : Person
    {   // инициализируем количество предметов
        private int MaxCourse = 3; 
        protected string[] studyCourses;
        public string[] StudyCourses
        {
            get
            {
                return studyCourses;
            }
            set
            {
                studyCourses = new string[MaxCourse];
                for (int i = 0; i < value.Length; i++)
                {
                    if (i < value.Length)
                    {
                        studyCourses[i] = value[i];
                    }
                    else // проблемно хз
                    {
                        Console.WriteLine("Только 3");
                    }
                }
            }
        }
        // Метод для перебора массива студентов
        public void DisplayStudyСourses()
        {
            foreach (var studyCourse in studyCourses)
            {
                Console.WriteLine(studyCourses);
            }
        }
        // Конструктор студентов + базовый конструктор переопределить
        public Student(int birthYear, string _name, string _surname)
            : base (birthYear, _name, _surname)
        {

        }
        public override string ToString()
        {
            return $"{base.ToString()} \nТип: Студент";
        }
    }

    class Teacher : Person
    {
        protected Student[] studentsArray;
        public Student[] StudentsArray
        {
            get
            {
                return studentsArray;
            }
            set
            {
                studentsArray = value;
            }
        }
        // Конструктор учителей + базовый конструктор переопределить
        public Teacher(int birthYear, string _name, string _surname)
            : base(birthYear, _name, _surname)
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} \nТип: Учитель";
        }
    }

    class PeopleInfo
    {
        private Person[] peopleArray;
        public Person[] PeopleArray
        {
            get
            {
                return peopleArray;
            }
            set
            {
                peopleArray = value;
            }
        }

        // Сортируем людей по возрасту и виводит от меншего
        private void SortPeoples()
        {
            for (int i = 0; i < peopleArray.Length; i++)
            {
                for (int j = i + 1; j < peopleArray.Length; j++)
                {
                    if (peopleArray[i].BirthYear > peopleArray[j].BirthYear)
                    {
                        Person person = peopleArray[i];
                        peopleArray[i] = peopleArray[j];
                        peopleArray[j] = person;
                    }
                }
            }
        }

        public void ShowPeoples()
        {   // сначала сортируем получение данние 
            SortPeoples();
            // затем выводим данные с помощью foreach
            foreach (Person people in peopleArray)
            {
                Console.WriteLine(people);
                Console.WriteLine();
            }
        }

        // метод для присвоение входящих параметров в массив екзепляров класа
        public PeopleInfo(params Person[] inputPeoples)
        {
            PeopleArray = inputPeoples;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу, в которой создайте базовый класс Person (человек), 
            в классе создайте поле типаint с именем BirthYear(год рождения), поле типа string с именем Name и поле типа stringс именем Surname.
            Далее создайте классы Student (студент), Teacher (преподаватель).
            В классе Student добавьте поле типа string[] с именем StudyCourses (изучаемые курсы), 
            свойство (не авто свойство) для добавления (set)и получения (get) изучаемых курсов и метод DisplayStudyСourses() 
            с возвращаемым значением void который будет выводить на консоль все предметы, максимальное количество изучаемых курсов = 3.
            В классе преподаватель создать поле типа Student[]с именем StudentsArray, 
            и свойство (не авто свойство) для добавления (set)и получения (get) студентов. 
            Создайте 5 экземпляров класса типа Studentи инициализируйте их произвольными значениями, 
            и 2 экземпляра класса типа Teacher, инициализируйте их произвольными значениями 
            (для инициализации поля StudentsArray используйте уже созданные экземпляры Student). 
            Далее создайте класс PeopleInfo, в нем создайте поле типа Person[]с именем PeopleArray 
            и свойство (не авто свойство) для добавления (set)и получения (get) людей и
            метод который будет выводить всех людей который есть в поле PeopleInfo в порядкевозрастания возраста.
            */
            #endregion

            Student student0 = new Student(1969, "Linus", "Torvalds");
            Student student1 = new Student(1962, "Gabe",    "Newell");
            Student student2 = new Student(1970, "John",   "Carmack");
            Student student3 = new Student(1955, "Bill",     "Gates");
            Student student4 = new Student(1975, "Bram",     "Cohen");
             
            Teacher teacher0 = new Teacher(1938, "Donald",      "Knuth");
            Teacher teacher1 = new Teacher(1950, "Bjarne", "Stroustrup");

            PeopleInfo peopleContainer = new PeopleInfo( student0, student1, student2, student3, student4, teacher0, teacher1);

            peopleContainer.ShowPeoples();

            Console.ReadKey();
        }
    }
    
}
