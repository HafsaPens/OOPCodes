using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_class_work
{
    class Program
    {
        static void Main(string[] args)
        {
            stack at = new stack();

            at.abc(0);
            Console.ReadKey();
        }
    }
    class stack
    {
     
        public void abc(int c)
        {
            if(c<=3)
            {
                Console.WriteLine(c);
                c++;
                abc(c);
                Console.WriteLine(c);
            
            }
            Console.WriteLine("I'm trying!!!");
        }
       
    }
}
