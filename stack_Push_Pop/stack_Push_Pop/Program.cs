using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_Push_Pop
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack_Functions st = new Stack_Functions();
            st.Push(10);
         
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Display();
            Console.ReadKey();
            st.Pop();
            st.Pop();
            st.Display();
            Console.ReadKey();






        }
    }
    class Stack_Functions
    {
        public int[] arr = new int[10];
        public int top = -1;  //For Empty Stack

        public void Push(int value)
        {
            if (top == arr.Length - 1)
            {
                Console.WriteLine("Strack Overflow!!!");
            }

                top++;
                arr[top] = value;
            
                //Or arr[++top]=value;
            
        }
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow or No elements to pop or delete!!!");
            }
            
              top--;

        }
        public void Display()
        {
            Console.WriteLine("The stack you created is:\n");
            for (int i=0;i<=top;i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
        }
    }
}
