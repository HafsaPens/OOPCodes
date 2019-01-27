using System;
namespace private_along_overloadedpublic_CONST
{
    class skyscraper
    { int summation;
        private skyscraper()
        { 
            Console.WriteLine("Private constructor executed");
        }
        public skyscraper(string name,string food)
        {
            Console.WriteLine($"{name} likes to eat {food}");
            
            }
        public skyscraper(string studentname,int marks,string subject)
        {
            Console.WriteLine($"{studentname} has scored {marks}  marks in {subject}");
            }
     }
    class Program
    {
        static void Main()
        {
            skyscraper obj1 = new skyscraper("Ali", 70, "OOP");
            skyscraper obj2 = new skyscraper("Sara", "Chicken currry");
            Console.ReadKey();
        }
    }
}
