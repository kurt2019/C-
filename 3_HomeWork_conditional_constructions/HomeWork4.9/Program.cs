using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Напишите программу русско-английский переводчик. Программа знает 10 слов о погоде.
            Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему 
            перевод этого слова на английском языке. Если пользователь ввел слово, для которого 
            отсутствует перевод, то следует вывести сообщение, что такого слова нет.  
            */
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();

            switch (word)
            {
                case "один":
                    Console.WriteLine($"{word} = One");
                    break;
                case "два":
                    Console.WriteLine($"{word} = Two");
                    break;
                case "три":
                    Console.WriteLine($"{word} = Three");
                    break;
                case "четыре":
                    Console.WriteLine($"{word} = four");
                    break;
                case "п'ять":
                    Console.WriteLine($"{word} = five");
                    break;
                case "шесть":
                    Console.WriteLine($"{word} = six");
                    break;
                case "семь":
                    Console.WriteLine($"{word} = seven");
                    break;
                case "восемь":
                    Console.WriteLine($"{word} = eight");
                    break;
                case "девять":
                    Console.WriteLine($"{word} = nine");
                    break;
                case "десять":
                    Console.WriteLine($"{word} = ten");
                    break;
                default:
                    Console.WriteLine($"{word} = это слово мне неизвестно");
                    break;
            }

            Console.ReadKey();
        }
    }
}
