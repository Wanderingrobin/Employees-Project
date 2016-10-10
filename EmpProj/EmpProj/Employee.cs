using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProj
{
    public class Employee
    {
        DateTime dateHired;
        DateTime termDate;
        double payRate;
        int grade;

        Department myDepart;


        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }

        public double PayRate
        {
            get
            {
                return payRate;
            }
            set
            {
                payRate = value;
            }
        }

        public DateTime DateHired
        {
            get
            {
                return dateHired;
            }
            set
            {
                dateHired = value;
            }
        }

        public DateTime TermDate
        {
            get
            {
                return termDate;
            }
            set
            {
                termDate = value;
            }
        }

        public string firstName { get; internal set; }

        public virtual void Hired(DateTime hDate)
        {
            dateHired = hDate.AddYears(-1);
        }

        public virtual bool Termed()
        {
            termDate = DateTime.Today;
            return true;
        }

        public void Raise(Double money)
        {
            payRate = money * 1.04;
        }

        internal void ChangeGrade(int v)
        {
            throw new NotImplementedException();
        }
    }
}
