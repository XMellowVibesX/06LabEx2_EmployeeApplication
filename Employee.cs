using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    internal class Employee
    {
        private string employeeID, firstName, lastName, position;

        public Employee(string employeeID, string firstName, string lastName, string position)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
