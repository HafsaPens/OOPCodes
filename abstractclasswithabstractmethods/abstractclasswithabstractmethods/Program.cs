using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclasswithabstractmethods
{
    public abstract class giraffe
    {
        public abstract void Ten();
        public void Eleven()
        {
            Console.WriteLine("Non abstract method in the abstrast class");
        }
        public abstract void toyota();
        
    }
    class van : giraffe
    {
        public override void Ten()
        {
           Console.WriteLine("ten class is an abstract one");
        }

        public override void toyota()
        {
            Console.WriteLine("class toyota is an abstract one");
        }
    }
    class program
    {
        static void Main()
        {
            van v = new van();
            v.Ten();
            v.Eleven();
            v.toyota();
            Console.ReadKey();
        }
    }
}
