using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubly_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            linked_list list = new linked_list();
            list.Append(78);
            list.Append(40);
            list.Append(80);
            list.Append(199);
            list.Print();
            Console.ReadKey();
            list.Insertat(44, 2);
            list.Print();
            Console.ReadKey();
            list.Prepend(50);
            list.Print();
            Console.ReadKey();
            list.delete_with_value(40);
            list.Print();
            Console.ReadKey();
            list.Insertat(7, 3);
            list.Print();
            Console.ReadKey();
            

        }
    }
   public class Dnode
    {
       public int data;
        public Dnode next;
        public Dnode prev;
        public Dnode(int data)
        {
            this.data = data;
        }
    }
    class linked_list
    {
        Dnode head;
        public void Append(int data)
        {
            if (head == null)
            {
                head = new Dnode(data);
                return;
            }
            Dnode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Dnode(data);
            return;
        }
        public void Insertat(int data, int after_what_position)
        {
            Dnode current = head;
            int ith_value = 1;
            while (ith_value != after_what_position)
            {
                current = current.next;
                ith_value++;

            }
            Dnode temp = current.next;
            Dnode Nnode = new Dnode(data);
            Nnode.next = temp;
            Nnode.prev = current;
            current.next = Nnode;
            temp.prev = Nnode;
            return;

        } 
        public void Prepend(int data)
        {
            Dnode Nhead = new Dnode(data);
            Nhead.next = head;
            head.prev = Nhead;
            head = Nhead;
        }
        public void Print()
        {
            Dnode current = head;
            while(current!=null)
            {
                Console.WriteLine(current.data);
                Console.WriteLine();
                current = current.next;
            }
        }
        public void delete_with_value(int data)
        {
            if(head.data==data)
            {
                head = head.next;
                return;
            }
            if(head==null)
            {
                return;
            }
            Dnode current = head;
            while(current.next!=null)
            {
                if(current.next.data==data)
                {

                    
                    current.next = current.next.next;
                    Dnode temp = current.next.next;
                    temp.prev = current;

                    
                    return;
                }
                current = current.next;
            }
        }

        }
    }

