using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaced
{
    interface isamsung
    {
        void camera();
    }
    interface ihuawei
    {
        void camera();
    }
    class enduser:isamsung,ihuawei
    {
        public enduser()
        {
            Console.WriteLine("constructor of the class has been shooted");
        }

        void isamsung.camera()
        {
            Console.WriteLine("samsung takes piics with 10 MP camera");
        }

        void ihuawei.camera()
        {
            Console.WriteLine("huawei takes pivs with 16 MP camera");
        }
    }
    class dew
    {
        static void Main()
        {
            ihuawei cam = new enduser();
            cam.camera();
            isamsung obj1 = new enduser();
            obj1.camera();
            
            Console.ReadKey();
        }
    }
    }

