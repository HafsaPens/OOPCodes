using System;
namespace this_keyword
{
    class box
    {
        public int l, b, h;
        public int volume()
        {
            return this.l * this.b * this.h;
        }
    }
    class program
    {
        static void Main()
        {
            box box1 = new box();
            box1.l = 5;
            box1.b = 5;
            box1.h = 5;
            Console.WriteLine("Volume of box1 is {0}", box1.volume());
            Console.ReadKey();
        }
    }
    
}
