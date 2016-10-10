using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProj
{
    public class Department
    {
        string deptName;
        string location;
        string managerName;

        public string DeptName
        {
            get
            {
                return DeptName;
            }
            set
            {
                DeptName = value;

            }
        }

        public virtual void ChangeDeptName(string newDepartName)
        {
            deptName = newDepartName;
        }
    }
}
