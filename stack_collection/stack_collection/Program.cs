using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack_collection
{
    class Program
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            stack.Push(400);
            stack.Push(500);
            Console.WriteLine(" The stack that we have is");
            foreach(int num in stack)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            Console.WriteLine(" Displaying the first member of the stack collection that we have:{0}",stack.Peek());
            Console.ReadKey();
            Console.WriteLine(" Removing the members of the stack from the top");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine(" Current stack is:");
            foreach(int num in stack)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(" Adding more values to our stack");
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine(" Our stack collection contains {0} values",stack.Count);
            Console.ReadKey();
            Console.WriteLine(" Current stack is:");
            foreach(int num in stack)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            Console.WriteLine(" REmoving the value from top of the stack that is {0}",stack.Pop());
            Console.ReadKey();
            Console.WriteLine(" Clearing the whole stack");
            stack.Clear();
            Console.WriteLine(" Current stack contains {0} values", stack.Count);
            Console.ReadKey();

        }
    }
}
