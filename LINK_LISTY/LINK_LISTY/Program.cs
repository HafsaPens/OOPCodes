using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINK_LISTY
{
    class Program
    {
        static void Main(string[] args)
        {
            LInked_LIst list = new LInked_LIst();
            list.Append(60);
            list.Append(90);
            list.Append(660);
            list.Append(70);
            list.Append(56);
            list.Print();
            Console.ReadKey();
            list.Update_the_Node(56,66);
            Console.ReadKey();
            list.Print();
            Console.ReadKey();
            list.Search_NODE_with_Data(90);
            Console.ReadKey();
            list.Delete_with_Value(66);
            list.Print();
            Console.ReadKey();
            
            list.Insertat(144, 4);
            list.Insertat(22, 2);
            Console.ReadKey();
            list.Print();
            Console.ReadKey();
            


            
        }
    }
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }

    }
    class LInked_LIst
    {
        Node head;
        public void Append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }
            Node current = head;
         
        
           while(current.next!=null)
            {
                current = current.next;
            }
            current.next = new Node(data);
            return;


        }
        public void Insertat(int data,int after_what_position)
        {
            Node current = head;
            int ith_value = 1;
            while(ith_value!=after_what_position)
            {
                current = current.next;
                ith_value++;
            }
            Node temp = current.next;
            Node Nnode = new Node(data);
            current.next = Nnode;
            Nnode.next = temp;
            return;


        }

        public void Prepend(int data)
        {
            Node newhead = new Node(data);
            newhead.next = head;
            head = newhead;
        }
        public void Delete_with_Value(int data)
        {
            if (head.data == data)
            {
                head = head.next;
                return;
            }
            
            
                Node current = head;
             while (current.next != null)
                {
                    if (current.next.data == data)
                    {
                   
                        current.next = current.next.next;
                    return;
                    }
                    current = current.next;
                }
            
            
        }
        public void Update_the_Node(int old_data, int new_data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == old_data)
                {
                    current.data = new_data;
                }
                current = current.next;
            }
        }
            public void Search_NODE_with_Data(int data)
            {
            Node current = head;
              while(current!=null)
            {
                if(current.data==data)
                {
                    Console.WriteLine("The node {0} has been searched",current.data);
                }
                current = current.next;
            }
            }
        public void Print()
        {
            Node current = head;
            while(current!=null)
            {
                Console.WriteLine("{0}\t", current.data);
                current = current.next;
            }
        }
        }
    }


