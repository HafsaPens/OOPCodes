using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace @interface
{ 
   
    interface ioppo
{

    void Price();

}
interface ihuawei
{
    void price();
}
}
class mobiles:ioppo,ihuawei
{
    public mobiles()
    {
        Console.WriteLine("class constructor execution");
    }

}
 

