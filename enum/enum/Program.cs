using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class dew
    {
        enum Gender { male,female,gay,lesbian}
        static void Main()
        {
            string name;
            int index;
            Gender gender;
            Console.WriteLine("please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("press 0 male,1 female,2 gay,3 lesbian");
            index = int.Parse(Console.ReadLine());
            gender = (Gender)index;
            Console.WriteLine("my name is {0} and i'm a {1}", name, gender);
            Console.ReadKey();


        }
       
    }
}
