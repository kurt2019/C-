using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте программу, в которой создайте два интерфейса IPlayable и IRecodable.
            В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() 
            и void Record() / void Pause() / void Stop() соответственно. Создайте производный класс Player
            от базовых интерфейсов IPlayable и IRecodable. Написать программу, которая выполняет проигрывание и запись.               
            */
            #endregion
            Console.WriteLine("Запускаем плеєр");
            Player player = new Player();
            player.Play();
            Console.WriteLine("Ставим на паузу");
            player.Pause();
            Console.WriteLine("Продолжаем");
            player.Play();
            Console.WriteLine("Заканчиваем");
            player.Stop();



            Console.ReadKey();
        }
    }
}
