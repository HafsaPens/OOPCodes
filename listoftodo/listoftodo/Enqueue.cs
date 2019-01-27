using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listoftodo
{
    class Enqueue
    {
        public int front = 0, rear = 0;
        public string[] s = new string[2];
        public Enqueue(string s1)
        {
            if(front==rear)
            {
                return;
            }
            else
            {
                s[rear] = s1;
                rear++;
            }
        }
        
    }
}
