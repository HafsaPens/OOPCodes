using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            stack st = new stack();
            st.Print(2);
            Console.ReadKey();
        }
    }
    class stack
    {
        
        public void Print(int c)
        {
            Console.WriteLine("c= " + c + "  on the stack!!!\n");
            if (c < 22)
                Print(c + 2);
            Console.WriteLine();
            Console.WriteLine("c= " + c + "  off the stack!!!\n");

        }

            
                }
            }
        
