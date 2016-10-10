using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProj
{
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected string changeName;
        protected string name;
        protected string newFirstName;
        protected string newLastName;
        protected DateTime dateBirth;
        protected string ssNum;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                LastName = value;
            }
        }

        public virtual void ChangeName(string newFirstName, string newLastName)
        {
            this.firstName = newFirstName;
            this.lastName = newLastName;
        }
    }
}
