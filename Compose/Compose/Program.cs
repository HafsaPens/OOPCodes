using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compose
{   enum Dep {art,com };

   class university
    {
        public List<department> departments=new List<department>();
        public void Adddepartment(string name,string directorname,Dep dep,int num)
        {
            if(dep==Dep.art)
            {
                artdepartment arts = new artdepartment();
                arts.Name = name;
                arts.Directorname = directorname;
                arts.NoOfStudents = num;
                departments.Add(arts);
            }
            else if(dep==Dep.com)
            {
                compdepartment comp = new compdepartment();
                comp.NoOfLabs = num;
                comp.Name = name;
                comp.Directorname = directorname;
                departments.Add(comp);

            }
            

        }
    }
}
