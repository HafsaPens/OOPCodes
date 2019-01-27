using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo
{
    class Print:Queue
    {
        public Print(string t):base(t)
        {
           for(int i=front;i<=rear-1;i++)
            {
                Console.Write(arrqueue[i]);
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
