using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abs_clas
{
    abstract class king
    {
        public king()
        {
            Console.WriteLine("why so serious?");
        }
         public abstract void hogwarts();
        public abstract void harry();

    }
    class prince : king
    {
        public prince ()
        {
            Console.WriteLine("because i like being serious");
        }

        public override void harry()
        {
            Console.WriteLine("cause we got the fire");
        }

        public override void hogwarts()
        {
            Console.WriteLine("and we gonna let it burn");
        }
    }
    class program
    {
        static void Main()
        {
            prince ter = new prince();
            ter.harry();
           ter.hogwarts();
             Console.ReadKey();
        }
    }
}
