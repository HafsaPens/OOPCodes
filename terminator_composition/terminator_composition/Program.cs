using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminator_composition
{
    class trifle
    {
        static void Main()
        {
            Big_industry b = new Big_industry();
            b.Add_department("qc department", 40, Big_industry.Torque.qc, 50);
            b.Add_department("packaging deptartment", 50, Big_industry.Torque.package, 22);
            foreach (common_data d in b.commons)
            {
                if (d is qc_department)
                {
                    qc_department qcdept = (qc_department)d;
                    Console.WriteLine("Department name is {0} that contains {1} workers who work with {2} scanners.", qcdept.department_name, qcdept.NoOfWorkers, qcdept.NoOfScanners);
                }
                else if (d is packagingdepartment)
                {
                    packagingdepartment packdept = (packagingdepartment)d;
                    Console.WriteLine("Department name is {0} that contains {1} workers who have to pack {2} cartons.", packdept.department_name, packdept.NoOfWorkers, packdept.NoOfCartons);
                }
            }
            Console.ReadKey();
        }
    }
}
