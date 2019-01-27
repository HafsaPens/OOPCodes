using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacing
{
    interface iking
    {
        void rule();
    }
    interface iprimeminister
    {
        void democracy();
    }
    class a : iking, iprimeminister
    {
        public void democracy()
        {
            Console.WriteLine("Elections are the best");
        }

        public void rule()
        {
            Console.WriteLine("Monarchy is the best");
        }
    }
    class program
    {
        static void Main()
        {
            a objname = new a();
            objname.rule();
            objname.democracy();
            Console.ReadKey();

        }
    }
}
