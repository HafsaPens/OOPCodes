using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
       public int myvariable;
        public Program()

        {
            myvariable = 28;
        }
    }
    class skyscraper
    {
        static void Main()
        {
            Program objname = new Program();
            Console.WriteLine("myvariable = {0}", objname.myvariable);
            Console.ReadKey();
        }
    }
}