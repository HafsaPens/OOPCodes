using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface88
{
  interface isecret
    {
        void transformer();


    }
    interface isuccess
    {
        void transformer();
    }
    class A : isecret, isuccess
    {
        public void transformer()
        {
            Console.WriteLine("i like to be transformed");
        }
    }
    class program
    {
        static void Main()
        {
            isuccess da = new A();
            da.transformer();
            A faa = new A();
            faa.transformer();
            Console.Read();
        }
    }
}
