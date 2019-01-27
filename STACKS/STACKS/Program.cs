using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACKS
{
    class Program
    {
        static void Main(string[] args)
        {
            trigger tri = new trigger();
            tri.Push(100);
            tri.Push(550);
            tri.Push(600);
            tri.Push(1000);
            tri.Printing();
            Console.ReadKey();
            tri.Push(190);
            Console.ReadKey();
            tri.Pop(600);
            Console.ReadKey();
            tri.Printing();
            Console.ReadKey();
            tri.Pop(1000);
            Console.ReadKey();
            tri.Printing();
            Console.ReadKey();
            tri.peek();
            Console.ReadKey();
        }
    }
    class trigger
    {
        int[] arr = new int[4];
        int top = -1;
        public void Push(int data)
        {
            if(top==arr.Length-1)
            {
                Console.WriteLine("\nThe value {0} can't be pushed because of Stack overflow!!!\n",data);
            }
            else
            {
                top++;
                arr[top] = data;
            }
        }
        public void Pop(int data)
        {
            if(top==-1)
            {
                Console.WriteLine("\nThe stack is currently empty!!!\n");
                
            }
            else if(arr[top]==data)
                {
                   top--;
                   Console.WriteLine("\nThe value {0} popped out from the stack!!!\n",data);
                }
            else
            {
                Console.WriteLine("\nThe stack member {0} you wanna pop out is not present at the top of the stack so can't be popped out!!!\n",data);
            }
            }
        
        public void Printing()
        {
            Console.WriteLine("The stack you created through array is\n");
            for(int i=0;i<=top;i++)
            {
                Console.WriteLine("{0}\n",arr[i]);
                Console.WriteLine();
            }

        }
        public void peek()
        {

            Console.WriteLine("The element present at the top of the stack is: {0}",arr[top]);
           
        }
    }


}
