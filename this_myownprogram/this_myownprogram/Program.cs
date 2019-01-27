using System;
namespace this_myownprogram
{
    class Program
    {
        public double pi = 3.14, radius;
        public double sphere()
        {
            return 1.33 *this.pi *this.radius * this.radius * this.radius;
        }

    }
    class Volume
    {
        static void Main()
        {

            Program obj = new Program();
            obj.radius = 5.3;
            Console.WriteLine("the volume of sphere is {0}", obj.sphere());
            Console.ReadKey();
        }
    }
}