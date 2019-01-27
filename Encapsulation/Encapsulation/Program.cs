using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
  class titanium
    {
        private int number;
        private string name;
        private int age;
        public void set_age(int a)
        {
            if(a > 0)
            {
                age = a;
            }
            else
            {
                Console.WriteLine("You have entered a non-age value");
            }
        }
        public void set_name(string k)
        {
            if(!string.IsNullOrEmpty(k))
            {
                name = k;
            }
            else
            {
                Console.WriteLine("Empty or null string can't be accepted");
            }
        }
        public void set_number(int f)
        {
            if(f > 10)
            {
                number = f;
            }
            else
            {
                Console.WriteLine("numbers can't be less than 10");
            }
        }
        public void display()
        {
            Console.WriteLine("Student name is {0} and his age is {1} and his numbers are {2}", name, age, number);
            
        }
    }
    class ele
    {
        static void Main()
        {
            titanium white_gold= new titanium();
            white_gold.set_name("Faryal");
            white_gold.set_age(20);
            white_gold.set_number(89);
            white_gold.display();
            Console.ReadKey();
        }
    }
}
