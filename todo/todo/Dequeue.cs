using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo
{
   public class Dequeue:Queue
    {
        public string element;
        public Dequeue(string n):base(n)
            {

            if(front==rear)
            {
                return;
            }
            else
            { element = arrqueue[front];
                Console.WriteLine("The TO-DO {0} has been dequed from the TO-DO List!!!",element);
                for(int i=0;i<rear-1;i++)
                {
                    arrqueue[i] = arrqueue[i + 1];
                }
                rear--;
                Console.Read();
            }

            }
    }
}
