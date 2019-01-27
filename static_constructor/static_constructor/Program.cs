using System;
namespace static_constructor
{
    class classadd
    {

        public classadd()
        {
            Console.WriteLine("4+2= {0}", 4 + 2);
            Console.WriteLine("default constructor");
        }
    }
    class program
    {
        static void Main()
        {
            classadd objname = new classadd();
            Console.ReadKey();
        }
    }
}
    

