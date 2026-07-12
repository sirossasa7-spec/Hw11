namespace Hw11
{
    class Play
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Play(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void Show()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Рік: {Year}");
        }

        ~Play()
        {
            Console.WriteLine($"Об'єкт {Name} видалено.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Play play = new Play("Гамлет", "Шекспір", "Трагедія", 1603);

            play.Show();

            play = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.ReadKey();
        }
    }
}
