using System;
namespace german_shephard
{
    class animal
    {
        public string name;
        public int age;
        public float bark_frquency;
        public void displaysuper()
        {
            Console.WriteLine($"name is {name}");
            Console.WriteLine($"age is {age}");
        }
        
        }
    class dog : animal
    {
        public int spotcount;
        public void bark()
        {
            Console.WriteLine("barking");
            base.bark_frquency += 2.0f;
        }
    }
    class program
    {
        static void Main()
        {
            dog d = new dog();
            d.name = "German Shepherd";
            d.age = 2;
            d.spotcount = 12;
            d.displaysuper();
            d.bark_frquency = 3.2f;
            d.bark();
            Console.WriteLine("spotcount={0}", d.spotcount);
            Console.WriteLine("barking frequency={0}", d.bark_frquency);
            Console.ReadKey();
        }
    }
    }

