using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composed
{
    class den
    {
        static void Main()
        {
            hungry hun = new hungry();
            hun.addfood("chinese", 1000, Suck.chinese, "spaghetti");
            hun.addfood("thai", 750, Suck.thai, "thai curry soup");
            foreach (flu f in hun.flus)
            {
                if (f is chinesefood)
                {
                    chinesefood chi = (chinesefood)f;
                    Console.WriteLine("name = {0}, price = {1}, specific item = {2}", chi.Name, chi.Price, chi.specificfood);


                }
                else if  (f is thaifood)
                {
                    thaifood thai = (thaifood)f;
                    Console.WriteLine("name = {0}, price = {1}, specific food = {2}", thai.Name, thai.Price, thai.specificsoup);
                }
                Console.ReadKey();
            }
        }
    }
}

