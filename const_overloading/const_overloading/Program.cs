using System;
namespace const_overloading
{
    class skyscraper
    {
        public static int A;
        static skyscraper()
        {
            Console.WriteLine("Static Constructor executed");
            A = 55;
        }
        public skyscraper(string name, int marks)
        {
            Console.WriteLine($"{name} got {marks}");

        }
        public skyscraper(string game, string player)
        {
            Console.WriteLine($"{player} is the champion of {game}");
            A = 66;
        }
        public void Display()
        {
            Console.WriteLine($"A={A}");

        }
    }
    class program
    {
        static void Main()
        {
            skyscraper obj1 = new skyscraper("Hafsa", 80);
            obj1.Display();
            skyscraper obj2 = new skyscraper("Tennis", "Roger Federer");
            obj2.Display();
            Console.ReadKey();

        }
    }
}

        
    

