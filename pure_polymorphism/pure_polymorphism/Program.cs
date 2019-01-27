using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pure_polymorphism
{
   interface istudy
    {
        void hardwork();
        

    }
    class maths : istudy
    {
        public void hardwork()
        {
            Console.WriteLine("i work hard in maths");
        }
    }
    class oop : istudy
    {
        public void hardwork()
        {
            Console.WriteLine("i work hard in oop");
        }
    }
    

    
    class program
    {
        static void Main()
        {
        istudy ma = new maths();
        ma.hardwork();
        oop na = new oop();
        na.hardwork();

            Console.ReadKey();
        }
    }
}
