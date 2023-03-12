using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgram
{
    public class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }


        public Department(string name, int workerLimit = 5, double salarylimit = 500 )
        {
            Employees = new List<Employee>();
            this.Name = name;
            this.WorkerLimit = workerLimit;
            this.Salarylimit = salarylimit;
           
        }

        private string name;
        public string Name 
        { 
            get { return this.name; }
            set
            {
                if (value.Length < 2)
                    Console.WriteLine("Department name's leght must be high than 2");
                else
                    this.name = value;  
            }
        }
      
        private int workerLimit;    
        public int WorkerLimit 
        { 
            get {return this.workerLimit; }
            set
            {
                if (value < 1)
                    Console.WriteLine("The number of employees must be at least 1");
                else
                    workerLimit = value;

            }
        
        }

        private double salaryLimit;
        public double Salarylimit
        {
            get { return this.salaryLimit; }
            set
            {
                if (value <= 250)
                    Console.WriteLine("The salary of the worker cannot be lower than 250");
                else
                    salaryLimit = value;
            }
        }

        public List<Employee> Employees { get; set; }

        public double CalcSalaryAverage()
        {
           double sum = 0;  
            
            foreach(Employee worker in Employees)
            {
                sum += worker.Salary;
            }

            return (sum / Employees.Count);
        }
    }
}
