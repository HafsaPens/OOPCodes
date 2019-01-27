using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_diff
{
    class fast
    {
        public int num1, num2;
        public fast()
        {
            num1 = 55;
        }
    }
    class speedy:fast
    {
        public speedy()
        {
            base.num2 = 66;

        }
    }
    class brake
    {
        static void Main()
        {
            speedy objname = new speedy();
            Console.WriteLine($"Number1 is {objname.num1}");
            Console.WriteLine($"Number2 is {objname.num2}");
            Console.ReadKey();
        }
    }
}
