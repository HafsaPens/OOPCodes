using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition
{
    class university
    {
        public artdept art;
        public compdept comp;
        public void iniartdept(string name,string artdirector,int noofstudents)
        {
            art = new artdept();
            art.Name = name;
            art.Artdirector = artdirector;
            art.NoOfStudents = noofstudents;
        }
        public void inicompdept(string name,string compdirector,int nooflabs)
        {
            comp = new compdept();
            comp.Name = name;
            comp.Compdirector = compdirector;
            comp.NoOfLabs = nooflabs;
        }
    }
}
