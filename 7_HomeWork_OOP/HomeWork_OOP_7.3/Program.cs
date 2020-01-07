using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_7._3
{
    class BankAccount
    {
        private string account_opening_date;     // дата открытия счета
        private double interest_rate_on_account; // процентная ставка по счету на месяц
        private double invoice_amount;           // сума счета 
        private double priority_contribution;    // первоочередный вклад

        public string Account_opening_date { get; set; }
        public double Interest_rate_on_account { get; set; }
        public double Invoice_amount { get; set; }
        public double Priority_contribution { get; set; }

        public int AmountOfDays()
        {
            double sum_for_month = Priority_contribution / 100 * Interest_rate_on_account; // сума процента за мецяц
            double count_day = (Invoice_amount - Priority_contribution) / sum_for_month; // сколько месяцей
            double days = count_day * 31;
            return Convert.ToInt32(days);
        }

        public void AmountOfDaysVoid()
        {
            Console.WriteLine($"Количество дней с даты откритыя счета: {AmountOfDays()}");
        }

        public double SumOfYear(int year)
        {
            int mounth = year * 12;
            double sum_years = Math.Round(((Priority_contribution / 100) * Interest_rate_on_account) * mounth, 2);
            return sum_years;
        }

        public void SumOFYearsVoid(int year)
        {
            Console.WriteLine($"Сума которая будет у вас на счету через {year} лет: {SumOfYear(year)}");
        }



    }
    // Метод который рассчитывает сумму, которая будет на счете через определенное количество лет(количество лет – параметр метода);
    // Метод который выводит информацию о сумме


    class Program
    {
        static void Main(string[] args)
        {
            #region
            /* Добавил переменную для первоочередного вклада */
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу в которой создайте класс «Банковский Счет».
            В теле класса создайте следующие поля: дата открытия счета, процентная ставка по счету,
            сумма счета.В теле метода создайте следующие методы: Метод, который рассчитывает количество дней,
            начиная с даты открытия счета; Метод который выводит информацию о количестве рассчитанных дней;
            Метод который рассчитывает сумму, которая будет на счете через определенное количество лет 
            (количество лет – параметр метода); Метод который выводит информацию о сумме. Также продумать 
            над конструктором класса. В методе Main() создайтеэкземпляр класса «Банковский Счет», присвойте 
            всем полям значение через свойства доступа, а также на экземпляр класса вызовите методы для отображения количества дней и суммы.
            */
            #endregion

            BankAccount UserOne = new BankAccount();

            Console.WriteLine("Введите дату открытия:");
            UserOne.Account_opening_date = Console.ReadLine();

            Console.WriteLine("Введите процентную ставку на месяц:");
            UserOne.Interest_rate_on_account = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите суму счета");
            UserOne.Invoice_amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите суму первоочередного вклада");
            UserOne.Priority_contribution = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество лет чтобы рассчитать сумму вашего счета на указаний год:");
            int years = Convert.ToInt32(Console.ReadLine());

            // Метод: AmountOfDays
            Console.WriteLine($"Количество дней с момента открытия счета : {UserOne.AmountOfDays()}");

            // Метод: AmountOfDaysVoid
            UserOne.AmountOfDaysVoid();

            // Метод: SumOfYear
            Console.WriteLine($"Сума которая будет у вас на счету через {years} лет: {UserOne.SumOfYear(years)}");

            // Метод: SumOFYearsVoid
            UserOne.SumOFYearsVoid(years);


            Console.ReadKey();
        }
    }
}
