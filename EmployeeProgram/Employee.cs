using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgram
{
    public class Employee
    {
        public static int Number = 1000;
        public Employee (string fullname, string position, double salary, string department)
        {
            this.No = department.Substring(0, 2) + Number.ToString();
            Number++;
            this.FullName = fullname;
            this.Salary = salary;
            this.Position = position;   
            this.DepartmentName = department;
        }

     
        public string No { get;  }
       
        public  string FullName { get; }
      

        private string position;
        public string Position 
        { 
            get { return this.position; }
            set
            {
                if (value.Length < 2)
                    Console.WriteLine("Position name's leght must be high than 2");
                else 
                    position = value;
            }
        }
        private  double salary; 
        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value <= 250)
                    Console.WriteLine("The salary of the worker cannot be lower than 250");
                else
                    salary = value; 
            }
        }
        public string DepartmentName { get;  }

       
    }
}
