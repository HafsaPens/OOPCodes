using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_from_Array_List_to_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Array List of type integer

            ArrayList integers = new ArrayList();
            integers.Add(10);
            integers.Add(20);
            integers.Add(100);
            integers.Add(280);
            integers.Add(470);
            integers.Add(660);
            integers.Add(55);
            integers.Add(500);
            integers.Add(33);
            integers.Add(440);

            //Function calling

            ToArray_Method(integers);

        }
           //Function Definition in which Array List is passed as a parameter

            static void ToArray_Method(ArrayList integers)
        {
             //For printing the Array List


            Console.WriteLine(" The Array List is:\n");
            foreach(int i in integers)
            {
                Console.Write("{0}  ",i);
            }
            Console.Write("\n");

            int[] Array =  integers.ToArray(typeof(int)) as int[];

            //For printing the elements of Array


            Console.WriteLine("\nThe elements in the Array are:\n");
            foreach(int i in Array)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }


}
