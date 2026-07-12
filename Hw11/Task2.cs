using System;

namespace Hw11
{
    class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public Shop(string name, string address, string type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void Show()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Адреса: {Address}");
            Console.WriteLine($"Тип: {Type}");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose() викликано.");
        }
    }

    internal class Task2
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("АТБ", "Київ", "Продовольчий");

            shop.Show();

            shop.Dispose();

            Console.ReadKey();
        }
    }
}
