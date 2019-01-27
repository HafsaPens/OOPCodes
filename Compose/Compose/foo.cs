using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Compose
{
    class foo
    {
        static void Main()
        {
            university uni = new university();
            uni.Adddepartment("compdepartment", "hafdsa iqbal", Dep.com, 12);
            uni.Adddepartment("artdepartment", "houdini", Dep.art, 500);
            foreach(department d in uni.departments)
            {
                if (d is artdepartment)
                {
                    artdepartment art = (artdepartment)d;
                    Console.WriteLine("|name = {0}, directorname ={1},no of students {2}", art.Name, art.Directorname, art.NoOfStudents);
                    Console.ReadKey();
                }
                else if (d is compdepartment)
                {
                    compdepartment comp = (compdepartment)d;
                    Console.WriteLine("name = {0}.directorname = {1},no of labs = {2}", comp.Name, comp.Directorname, comp.NoOfLabs);
                    Console.ReadKey();
                }
               

            }
        }


    }
}

