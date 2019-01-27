using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    abstract class Fantum
    {
        public Fantum()
        {
            Console.WriteLine("Abstract class constructor");
        }
        public abstract void display();
        public abstract void pant();
        public void elephant()
        {
            Console.WriteLine("A fat animal");
        }
            
        
    }
    class water : Fantum
    {
        public override void display()
        {
            Console.WriteLine("How are you?");
        }

        public override void pant()
        {
            Console.WriteLine("I'm fine");
        }

    }
    class program
    {
        static void Main()
        {
            Fantum fan = new water();
            fan.display();
            fan.pant();
            fan.elephant();
            Console.ReadKey();
        }
    }
}
