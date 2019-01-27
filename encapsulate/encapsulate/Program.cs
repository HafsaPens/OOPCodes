using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulate
{
    class Program
    {
       

            private int Age;
        private string Name;
        public void set_age(int age)
        {
            if (age > 20)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("you have entered some invalid data!");
            }
        }
        public void set_name(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("you have set some null or empty string");
            }
        }

        
        public void display()
        {
            Console.WriteLine("name is {0} and age is {1}", Name,Age);
        }

    }
    class gif
    {
        static void Main()
        {
            Program pro = new Program();
            pro.set_age(30);
            pro.set_name("irfan");
            pro.display();
            Console.ReadKey();
        }

    }

}    

