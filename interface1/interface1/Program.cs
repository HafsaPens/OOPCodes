using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
  interface iruler
    {
        void rule();
    }
    class primeminister : iruler
    {
        public void rule()
        {
            Console.WriteLine("i can rule country by elections");
        }
        class president : iruler
        {
            public void rule()
            {
                Console.WriteLine("i can rule the country by selection");
            }
        }
        class program
        {
            static void Main()
            {
                iruler fa = new primeminister();
                fa.rule();
                president pa = new president();
                pa.rule();
                Console.ReadKey();

            }
        }
    }
}
