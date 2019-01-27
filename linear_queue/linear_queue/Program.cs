using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Dequeue();
            Console.ReadKey();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Enqueue(40);
            que.Enqueue(50);
            que.Enqueue(60);
            que.Print();
            Console.ReadKey();
            que.Dequeue();
            que.Dequeue();
            Console.ReadKey();
            que.Print();
            Console.ReadKey();
        }
    }
    public class Queue
    {

        public int rear = 0, front = 0;
        public int  [] arrQueue = new int[5];
        public void Enqueue(int value)
        {
            if (rear == arrQueue.Length)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
             arrQueue[rear] = value;
                rear++;

            }

        }
        public void Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("\nThe queue is empty!!!\n");
            }
            else
            {
                Console.WriteLine("\nThe element deleted from the queue is {0}\n", arrQueue[front]);

                for (int i = front; i < rear - 1; i++)
                {
                    arrQueue[i] = arrQueue[i + 1];
                }
                rear--;
            }
        }
        public void Print()
        {
            Console.WriteLine("The queue elements are:\n");
            for(int i=front;i<=rear-1;i++)
            {
                Console.WriteLine(arrQueue[i]);

            }
        }
            
        }
    }

