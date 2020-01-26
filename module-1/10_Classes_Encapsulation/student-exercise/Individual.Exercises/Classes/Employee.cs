using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        public int EmployeeId { get;  }
        public string FirstName { get; }

        public string LastName { get; set; }

        //this is a constructor(below))
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
        }
        
        public string FullName { 
            get 
            {
                return LastName + ", " + FirstName;
            } 
        }

        public string Department { get; set; }

        public double AnnualSalary { get; private set; }
        public void RaiseSalary(double percent)

        {
           double percentage = percent / 100;
            this.AnnualSalary = AnnualSalary + (AnnualSalary*(percentage));
        }

    }
}
