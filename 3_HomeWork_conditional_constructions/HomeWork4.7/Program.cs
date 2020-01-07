using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application. Напишите программу - консольный калькулятор.
            Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые произвольные значения. Предложите
            пользователю ввести знак арифметической операции. Примите значение введенное пользователем и поместите его в строковую
            переменную sign. Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch. Выведите
            на экран результат выполнения арифметической операции. В случае использования операции деления, организуйте проверку 
            попытки деления на ноль. И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя. 
            */
            Console.WriteLine("Введите 1 число:");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите знак арифметической операции:");
            string sing = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Введите 2 число:");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double result;

            switch (sing)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine($"Добавление = {result}");
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine($"Вычитание = {result}");
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine($"Умножение = {result}");
                    break;
                case "/":
                    if (operand1 == 0 || operand2 == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя, только в высшей математике можно))");
                    }
                    else
                    {
                        result = operand1 / operand2;
                        Console.WriteLine($"Добавление = {result}");
                    }
                    break;
                case "%":
                    result = operand1 % operand2;
                    Console.WriteLine($"По модулю = {result}");
                    break;
                default:
                    Console.WriteLine("Вы ввели неверный знак");
                    break;
            }

            Console.ReadKey();
        }
    }
}
