
using System;
namespace overloadingconst

{
    class student
    {
        public string n,a,h;
        public int b;
        public char faded;

        public student(string h,char faded)
        {
            this.n;
        }
        public student(string n)
        {

            
        }
        public student(string a, int b)
        {


            Console.WriteLine("The student can study {0},{1} and {2} altogether.",h,n,a);
        }
    }
    class teacher
    {
        public int buck_beak;
        public string flee, siesta;
        public teacher(string flee)
        {

          }
        public teacher(string siesta, int buck_beak)
        {


            Console.WriteLine("The teacher can teach {0} and {1} atogether.", flee,siesta);
        }
    }
    class Program
    {
        static void Main()
        {
            student stu = new student("OOP",'f');
            student stu1 = new student("MATHEMATICS");
            student stu2 = new student("ISLAMIAT", 3);
            teacher tea = new teacher("OOP");
            teacher tea1 = new teacher("MATHEMATICS", 2);
            Console.ReadKey();
        }
    }
}
