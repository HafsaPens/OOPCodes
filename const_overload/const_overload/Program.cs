using System;
namespace const_overload
{
   public class Program
    {
       public static int A;
       public int B;
        static Program()

        {
            Console.WriteLine("static constructor executed");
            A = 16;
        }
        public Program(int b)
        {
            Console.WriteLine("instance constructor executed");
            this.B = b;


        }

       public void Display()
        {
            Console.WriteLine($"{A}");
            Console.WriteLine($"{B}");
        }
    }
        class foo:Program
        {
         int S;
       public foo (int s):base(s)
        {
            Console.WriteLine("derived const executed");
            this.S = s;
        }

        }
        class jaguar
        {
            static void Main()
            {
            foo f1 = new foo(4);
            f1.Display();
            foo fan = new foo(5);
            fan.Display();


                
            

                Console.ReadKey();
            }
        }
    }

