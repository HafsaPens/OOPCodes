using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace enum_typecasting
{
    class hafsa
    {   enum Week { monday,tuesday,wednesday,thursday,friday,saturday,sunday};
        static void Main()
        {
            
            int index;
            string name;
            Console.WriteLine("enter your name");
                name = Console.ReadLine();
            Console.WriteLine("press 0 monday,1 tuesday,2 wednesday,3 thursday,4 friday,5 saturday,6 sunday");
            index = int.Parse(Console.ReadLine());
          Week  week = (Week)index;
            Console.WriteLine("my name is {0} and i like {1}", name, week);
            Console.ReadKey();
            
}
    } }
