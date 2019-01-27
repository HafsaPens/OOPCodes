using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminator_composition
{
    class Big_industry
    {
        public enum Torque {qc,package};
        public List<common_data> commons = new List<common_data>();
        public void Add_department(string name,int noofworkers,Torque torque,int num)
        {
            if(torque==Torque.qc)
            {
                qc_department qcdept = new qc_department();
                qcdept.department_name = name;
                qcdept.NoOfWorkers = noofworkers;
                qcdept.NoOfScanners = num;
                commons.Add(qcdept);
            }
            else if(torque==Torque.package)
            {
                packagingdepartment packdept = new packagingdepartment();
                packdept.department_name = name;
                packdept.NoOfWorkers = noofworkers;
                packdept.NoOfCartons = num;
                commons.Add(packdept);
            }
        }


    }
}
