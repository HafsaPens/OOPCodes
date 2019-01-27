using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virt_oveeride
{
    class transformer
    {
        public transformer()
        {
            Console.WriteLine("like to be converterd in different forms");
        }
        public virtual void run()
        {
            Console.WriteLine("run transformer");
        }
    
   }
    class Car : transformer
    {
        public override void run()
        {
            Console.WriteLine("run car");
        }
        public void display()
        {
            Console.WriteLine("i like cars");
        }
    }
    class boat:transformer
    {
        public boat()
        {
            Console.WriteLine("i like boats");
        }
        public override void run()
        {
            Console.WriteLine("run boat");
        }
    }

    class program
    {
        static void Main()
        {
            Car ca = new Car();
            ca.run();
            ca.display();
            boat bo = new boat();
            bo.run();
            Console.ReadKey();

        }
    }
}
