using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2interfaceswithsamefunctcalledexplicut
{
    interface itransformer
    {
        void run();
    }
    interface iexample
    {
        void run();
    }
    class water : itransformer, iexample
    {
        void itransformer.run()
        {
            Console.WriteLine("run transformer");
        }

        void iexample.run()
        {
            Console.WriteLine("run example");
        }
    }
    class program
    {
        static void Main()
        {
            itransformer ta = new water();
            ta.run();
            water wa = new water();
            iexample ex = new water();
            ex.run();
            Console.ReadKey();
        }
    }
}