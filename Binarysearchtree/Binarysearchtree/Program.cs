using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarysearchtree
{
  public  class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class BST
    {
        public Node Root;
     
     
       
        public void ADD_Node(int data)
        {   
           
           
            if(Root==null)
            {
                Root = new Node(data);
            }
            else
            {

                Node current = Root;
            }
        }
    }
}
