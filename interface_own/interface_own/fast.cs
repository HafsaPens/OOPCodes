using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_own
{
    class fast
    {
        static void Main()
        {
            article1 obj1 = new article1();
            article2 obj2 = new article2();
            obj1.MakingHardware();
            obj2.MakingHardware();
            Console.ReadKey();
        }
    }
}
