using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    class customer
    {
        public int ID { get; set; }
        public string Name {get;set;}
    }
    class program
    {
        static void Main()
        {
            customer cust1 = new customer();
            {
                cust1.ID = 101;
                cust1.Name = "Hafsa";
            }
            customer cust2 = new customer();
            {
                cust2.ID = 202;
                cust2.Name = "Ayesha";
            }
            customer cust3 = new customer();
            {
                cust3.ID = 303;
                cust3.Name = "Mahrukh";
            }
            customer cust4 = new customer();
            {
                cust4.ID = 404;
                cust4.Name = "Tahira";
            }


            Queue<customer> qc = new Queue<customer>();
            //creation of queue of customer
            //enqueue
            qc.Enqueue(cust1);
            qc.Enqueue(cust2);
            qc.Enqueue(cust3);
            qc.Enqueue(cust4);
            foreach (customer c in qc)
            
               
                {
               Console.WriteLine("ID is {0} and Name is {1}", c.ID, c.Name);
                Console.ReadKey();
                //ceation of queue of size four and printing//
            }
            cust1 = qc.Dequeue();
            Console.WriteLine("ID = " + cust1.ID + "name =  " + cust1.Name);
            Console.WriteLine("Total number of customers available in the queue is " + qc.Count());
            Console.ReadKey();
            //dequeue cust1//
            if(qc.Contains(cust1))
            {
                Console.WriteLine(" cust1 exists");
            }
            else
            {
                Console.WriteLine("cust1 doesnot exist");
            }
            Console.ReadKey();
            //to check whether a particular object exists in the queue or not we use Contain method//
            qc.Peek();
            Console.WriteLine("ID is " + cust2.ID + "Name is " + cust2.Name);
            
            Console.ReadKey();
        }

    }
        
 }


    
