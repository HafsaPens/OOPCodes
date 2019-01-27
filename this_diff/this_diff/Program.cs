using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_diff
{
    class skyscraper
    {
        public int num1,num2,add;
        public void Add(int a,int b)
        {
            this.num1 =a;
            this.num2 = b;
            add = num1 + num2;
            Console.WriteLine($"Addition of gien two numbers gives {add}");

        }
    }
    class program
    {
        static void Main()
        {
            skyscraper objname = new skyscraper();
            objname.Add(50,90);
            Console.ReadKey();
        }
    }
}
