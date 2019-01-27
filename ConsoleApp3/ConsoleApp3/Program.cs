using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class teacher

    {
        public string a;
        public teacher()

        {
            Console.WriteLine("The teacher can teach OOP");
        }
        public teacher(string a)
        {
            Console.WriteLine("The teacher can teach {0}", a);
        }
    }
    class student
    {
        public string x, y;
        char z;
        public student()
        {
            Console.WriteLine("The student can study OOP");
        }
        public student(string x)
        {
            Console.WriteLine("The student can study {0}", x);
        }
        public student(string y, char z)
        {
            Console.WriteLine("The student can study {0}", y);
        }
    }
    class Program
    {
        static void Main()
        {
            student stu = new student();
            student stu1 = new student("MATHEMATICS");
            student stu2 = new student("ISLAMIAT", 'd');
            teacher tea = new teacher();
            teacher tea1 = new teacher("MATHEMATICS");
            Console.ReadKey();
        }
    }
}
        
           
        
    
     
   

