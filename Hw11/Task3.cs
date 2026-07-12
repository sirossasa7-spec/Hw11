using System;

namespace Hw11
{
    class Play : IDisposable
    {
        public string Name { get; set; }

        public Play(string name)
        {
            Name = name;
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose для Play.");
        }

        ~Play()
        {
            Console.WriteLine("Деструктор Play.");
        }
    }
    class Shop : IDisposable
    {
        public string Name { get; set; }

        public Shop(string name)
        {
            Name = name;
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose для Shop.");
        }

        ~Shop()
        {
            Console.WriteLine("Деструктор Shop.");
        }
    }
    internal class Task3
    {
        static void Main(string[] args)
        {
            Play play = new Play("Гамлет");
            Shop shop = new Shop("АТБ");

            play.Dispose();
            shop.Dispose();

            play = null;
            shop = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.ReadKey();
        }
    }
}
