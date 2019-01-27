using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_through_array
{
    class Program
    {
        static void Main(string[] args)
        {

            stack_functions fun = new stack_functions();
            fun.Push(30);
            fun.Push(20);
            fun.Push(100);
            fun.Push(150);
            fun.Push(360);
            fun.Push(200);
            fun.Push(990);
            fun.Push(870);
            fun.Print();
            fun.Pop();
            fun.Print();
            Console.ReadKey();

        }
    }
    class stack_functions
    {
        int[] arr = new int[7];
        public int top = -1;
        public int value;
        public void Push(int value)
        {
            if (top == arr.Length - 1)
            {
                Console.WriteLine("Stack overflow!!!");
            }
            else
            {
                top++;

                arr[top] = value;
            }
                
            
        }
        public void Print()
        {
            Console.WriteLine("The stack you made is:\n");
            for (int i = 0; i <= top; i++)
            {
                Console.Write("{0}", arr[i]);
                Console.WriteLine();
            }

            }
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("The stack is empty,so there is no element to Pop!!!");
            }
            else
            {
                Console.WriteLine("The value off the stack is {0}", arr[top]);
                top--;
            }
            
        



        }
    }
}
