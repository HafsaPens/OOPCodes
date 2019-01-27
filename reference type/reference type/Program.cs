using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_type
{
    class Program
    {
        public int age;
        public int marks;
        
        }
    class bugatti
    {
        static void Main()
        {
            Program pro = new Program();
            pro.age = 30;
            pro.marks = 100;
            Program pro2 = pro;
            Console.WriteLine("Changing the age to 75 in pro");
            pro.age = 75;
            Console.WriteLine("the age in pro2 will also receive the change implicitly");
            Console.WriteLine("pro2 age is {0}",pro2.age);
            Console.ReadKey();
        }
    }
    }

