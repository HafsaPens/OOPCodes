using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirst
{
    class Program
    {
        public double l, b, h;
        public void volume_of_box()
        {
            Console.WriteLine("the volume of box is {0}", l * b * h);
        }
    }
        class SKYSCRAPER
        {
            static void Main()
            {
                Program objname = new Program();
                objname.l = 10;
                objname.b = 10;
                objname.h = 10;
                objname.volume_of_box();
            Console.ReadKey();
            }
        }
    }
       
        
        
    

