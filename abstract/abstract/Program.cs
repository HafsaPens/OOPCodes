using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    abstract class Program
    {
        public int num = 400000;
        public Program()
        {
            Console.WriteLine("constructor of the base class executed");
            

        }
        public abstract void terminator();
        public void captain_america()
        {
            Console.WriteLine("Captain America currently has {0}$", num);
        }
    }
    class drama : Program
    {
        public drama()
        {
            Console.WriteLine("child clss constructor has been executed");
        }

        public override void terminator()
        {
            Console.WriteLine("terminator can run,swim and fly");
        }

    }
    class flat
    {
        static void Main()
        {
            drama dra = new drama();
            dra.terminator();
            dra.captain_america();
            Console.ReadKey();
        }
    }
}

