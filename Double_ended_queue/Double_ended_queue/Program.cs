using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_ended_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleEnded_Queue D = new DoubleEnded_Queue();
            D.EnqueueFront(5);
            D.EnqueueRear(10);
            D.EnqueueRear(20);
            D.EnqueueRear(30);
            Console.ReadKey();
            D.Print();
            Console.ReadKey();
            D.DequeueFront();
            Console.ReadKey();
            D.EnqueueFront(5);
            D.Print();
            Console.ReadKey();
            D.EnqueueFront(4);
            Console.ReadKey();
            D.Print();
            Console.ReadKey();
            D.DequeueRear();
            D.Print();
            D.PeekFront();
            Console.ReadKey();
        }
    }
    class DoubleEnded_Queue
    {
        public int count = 0, front = 0, rear = -1;
        public int[] arrDQueue = new int[10];
        public void EnqueueRear(int data)
        {
            if (count == arrDQueue.Length)
            {
                Console.WriteLine("Enqueue not possible.Double Ended Queue is overflow!!!");
                return;
            }
            else
            {
                rear = (rear + 1) % arrDQueue.Length;
                arrDQueue[rear] = data;
                count++;
            }
        }
        public void DequeueFront()
        {
            if(count==0)
            {
                Console.WriteLine("\nDequeue not possible.Double Queue is empty!!!\n");
                return;
            }
            else
            {
                int temp = arrDQueue[front];
                Console.WriteLine("\nThe element dequeued from front position in double ended queue is {0}\n", temp);
                front = (front + 1) % arrDQueue.Length;
            }
        }
        public void EnqueueFront(int data)
        {
            if (front == 0)
            {
                Console.WriteLine("\nEnqueue from front is not possible as there is no index before 0th index\n");
            }
            else
            {
                front = (front - 1) % arrDQueue.Length;
                arrDQueue[front] = data;
                Console.WriteLine("The element enqueued from front position in the double ended queue is {0}", arrDQueue[front]);
        } }
        public void DequeueRear()
        {
            if(count==0)
            {
                Console.WriteLine("\nThe Double Ended queue is empty so Dequeue not possilbe!!!\n ");
            }
            else
            {
                int temp = arrDQueue[rear];
                Console.WriteLine("\nThe element Dequeued from rear position in Double ended queue is {0}\n", temp);
                rear = (rear - 1) % arrDQueue.Length;
            }
        }
        public void Print()
        {
            Console.WriteLine("The elements present in the Double Ended Queue are:\n");
            for(int i=front;i<=rear;i++)
            {
                Console.Write("{0}\t", arrDQueue[i]);
            }
        }
        public void PeekFront()
        {
            int temp = arrDQueue[front];
            Console.WriteLine("\nThe element peeked from front is {0}\n", temp);
        }
    }
}
