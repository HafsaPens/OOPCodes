using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo
{
    public class Queue
    {
        public int front = 0, rear = 0;
        public string[] arrqueue = new string[4];
        public Queue(string s)
        {
            if(rear==arrqueue.Length)
            {
                return;
            }
            else
            {
                arrqueue[rear] = s;
                rear++;
                
            }
        }
    }
}
