using System;
namespace courses_constructors
{
    class student
    {
        public string n;
        public string a;
        public int b;

        public student()
        {
            Console.WriteLine("The student can study OOP");
        }
        public student(string n)
        {
           
            Console.WriteLine("The student can study {0}", n);
        }
        public student(string a, int b)
        {
           

            Console.WriteLine("The student can study {0}", a);
        }
    }
    class teacher
    {
        public int buck_beak;
        public string flee, siesta;
        public teacher(string flee)
        {
            
            Console.WriteLine("The teacher can teach {0}", flee);
        }
        public teacher(string siesta, int buck_beak)
        {
            

            Console.WriteLine("The teacher can teach {0}", siesta);
        }
    }
    class Program
    {
        static void Main()
        {
            student stu = new student();
            student stu1 = new student("MATHEMATICS");
            student stu2 = new student("ISLAMIAT", 3);
            teacher tea = new teacher("OOP");
            teacher tea1 = new teacher("MATHEMATICS", 2);
            Console.ReadKey();
        }
    }
}
