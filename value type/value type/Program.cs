using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_type
{
    struct person
    {
        public int age;
        public int marks;
    }
    class program
       
        {
        static void Main()
        { 
        person per = new person();
        per.age=30;
        per.marks=70;
            person per2 = per;
            Console.WriteLine("Changing the age of per to 15");
            per.age = 15;
            Console.WriteLine("per2 age is {0}",per2.age);
            Console.WriteLine("Changing explicitly the age of per2 as the ages of per and per2 shouold be same");
            per2.age = per.age;
            Console.WriteLine("age of per2 is {0}", per2.age);
            Console.ReadKey();
        }
    }
}
