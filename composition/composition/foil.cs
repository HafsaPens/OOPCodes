using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition
{
    class foil
    {
        static void Main()
        {
            university ubit = new university();
            ubit.iniartdept("sada","taqi",500);
            ubit.inicompdept("ubit","umaer basha",2000);
            Console.ReadKey();
        }
    }
}
