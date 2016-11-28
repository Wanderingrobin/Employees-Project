using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProj
{
    public class Program
    {
        public static Employee[] newArray { get; private set; }

        static void Main(string[] args)
        {

            string UserInput;

            Department myDepart = new Department();
            myDepart.DeptName = "Freddy Fazbear Security Manager";
            myDepart.ChangeDeptName("FF Security");

            Console.WriteLine("We've changed the department name because we no longer has a... have NEED OF a security manager.");


            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();
            Employee emp5 = new Employee();


            emp1.firstName = "Mike";
            emp1.lastName = "Schmidt";
            emp2.firstName = "Jeremy";
            emp2.lastName = "Fitzgerald";
            emp3.firstName = "Fritz";
            emp3.lastName = "Smith";
            emp4.firstName = "Umari";
            emp4.lastName = "Fuller";
            emp5.firstName = "Mark";
            emp5.lastName = "Fischbach";

            emp1.ChangeName("Nachelle", "Allen");

            Employee[] ffArray = new Employee[5];
            ffArray[0] = emp1;
            ffArray[1] = emp2;
            ffArray[2] = emp3;
            ffArray[3] = emp4;
            ffArray[4] = emp5;

            emp1.Grade = 12;
            emp2.Grade = 7;
            emp3.Grade = 10;
            emp4.Grade = 19;
            emp5.Grade = 25;

            emp1.PayRate = 120;
            emp1.Raise(emp1.PayRate);
            emp1.ChangeGrade(13);

            emp4.DateHired = DateTime.Today;
            emp4.Hired(emp4.DateHired);
            emp3.DateHired = DateTime.Today.AddYears(-3);

            emp5.DateHired = DateTime.Today.AddYears(-1);
            emp5.TermDate = DateTime.Today;

            Console.WriteLine();
            Console.WriteLine(emp1.firstName + " " + emp1.lastName + " " + "was promoted from grade 12 to " + emp1.Grade);
            Console.WriteLine(emp1 + " was hired in on" + emp1.DateHired.ToShortDateString());
            Console.WriteLine(emp5 + "was hired in on" + emp5.DateHired.ToShortDateString() + " and terminated on " + emp5.TermDate.ToShortDateString());
            Console.WriteLine();

            Util.Pay(newArray);

            List<Employee> myEmpList = new List<Employee>();
            Console.WriteLine("Enter your emp.");
            Console.WriteLine();
            while (AddNewEmp("User Input"))
            {
                for (int i = 0; i<= myEmpList.Count; i++)
                {
                    myEmpList.Add(new Employee());
                    myEmpList[i].firstName = Console.ReadLine();
                }
            }

            Console.WriteLine("Want to add another emp? y|n?");

            Console.ReadLine();

        }
        static bool AddNewEmp(string x)
        {
            if (x == "y") 
            {
                return true;
            }
            else if (x == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Only two choices here, y|n");
                return false;
            }
        }
    }
}
