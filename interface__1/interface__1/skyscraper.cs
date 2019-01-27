using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface__1
{
    class skyscraper
    {
        static void Main()
        {
            star obj1 = new star();
            square obj2 = new square();
            string s1 = obj1.MakingPendants();
            string s2 = obj2.MakingPendants();
            Console.WriteLine("Calling star class " +s1);
            Console.WriteLine("Calling square class"  + s2);
            Console.ReadKey();

        }

    }
}
