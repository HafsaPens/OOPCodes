using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Circular
{
    class Program
    {
        static void Main(string[] args)
        {
            Circular_Queue cir = new Circular_Queue();
            cir.Enqueue(10);
            cir.Enqueue(20);
            cir.Enqueue(30);
            cir.Enqueue(40);
            cir.Enqueue(50);
            cir.Enqueue(60);
            cir.Print();
            Console.ReadKey();
            cir.Dequeue();
            cir.Dequeue();
            cir.Dequeue();
            cir.Dequeue();
            cir.Dequeue();
            cir.Dequeue();
            cir.Print();
            Console.ReadKey();
            cir.Enqueue(100);
            cir.Enqueue(200);
            cir.Enqueue(300);
            cir.Print();
            Console.ReadKey();
            Console.ReadKey();

        }
    }
    class Circular_Queue
    {
        public int front = -1, rear = -1;
        public int[] arrCQueue = new int[5];
        public int value;
        public void Enqueue(int data)
        {
            if ((rear + 1) % arrCQueue.Length == front)
            {
                Console.WriteLine("The queue is full,so Enqueue not possible");
            }
            else
            {
                if (rear == -1 && front == -1)
                {
                    rear = 0;
                    front = 0;
                
                }
                else
                {
                    rear = (rear + 1) % arrCQueue.Length;
                }
                Console.WriteLine("\nThe element enqueued in the Circular queue is {0}\n", data);
                arrCQueue[rear] = data;
                
            }
        }
        public void Dequeue()
        {

            if (front == -1 && rear == -1)
            {
                Console.WriteLine("\nThe Circular queue is empty,so Dequeue is not possible\n");
            }
            else
            {

                value = arrCQueue[front];
                Console.WriteLine("\nThe element dequeued from the Circular queue is {0}\n", value);
                if (rear == front)
                {
                    rear = -1;
                    front = -1;
                   
                }
                else
                {
                    front = (front + 1) % arrCQueue.Length;
                    return;
                }
            }
        }
        public void Print()
        {
            if (rear == -1 && front == -1)
            {
                Console.WriteLine("The queue is empty!!!");
            }
            else
            {
                Console.WriteLine("\nThe elements in the Circular queue are:\n");
                if (front <= rear)
                {
                    for (int i = front; i <= rear; i++)
                    {
                        Console.WriteLine(arrCQueue[i]);

                    }
                }
                else
                {
                    for (int i = front; i <= rear; i++)
                    {
                        Console.WriteLine(arrCQueue[i]);
                    }
                }
            }
        }
    }

}
      
    
    
