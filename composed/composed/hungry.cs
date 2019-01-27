using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composed
{   enum Suck { chinese,thai}
    class hungry
    {
        public List<flu> flus = new List<flu>();
        public void addfood(string name,int price,Suck suck,string taste)
        {
            if (suck==Suck.chinese)
            {
                chinesefood chi = new chinesefood();
                chi.Name = name;
                chi.Price = price;
                chi.specificfood = taste;
                flus.Add(chi);
            }
            else if(suck==Suck.thai)
                {
                thaifood thai = new thaifood();
                thai.Name = name;
                thai.Price = price;
                thai.specificsoup = taste;
                flus.Add(thai);

            }
        }
    }
}
