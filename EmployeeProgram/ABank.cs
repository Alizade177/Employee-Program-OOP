using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgram
{
    public class ABank : IHumanResourceManager
    {
        public ABank()
        {
            Departments = new List<Department>();
        }
        public List<Department> Departments { get; set; }

        public void AddDepartment(string name, int wLimit, double sLimit)
        {
            Department department = new Department(name, wLimit, sLimit); 
            this.Departments.Add(department);   
        }

        public void AddEmployee(string departmentName, string fullname, string position, double salary)
        {
            bool isHave = false;
            foreach (Department item in this.Departments)
            {
                if (item.Name == departmentName)
                {
                    Employee employee = new Employee(fullname, position, salary, departmentName);

                    item.Employees.Add(employee);
                    isHave = true;
                    break;
                }
                
            }

            if (!isHave)
                Console.WriteLine("There is no department like this!");
        }

        public void EditDepartments(string departmentName, string newDepartmentName)
        {
            bool isHave = false;
           foreach(Department item in this.Departments)
            {
                if (item.Name == departmentName)
                {

                    item.Name = newDepartmentName;
                    isHave = true;
                    break;
                }

                if (isHave)
                    Console.WriteLine("Emeliyyat ugulu oldu!");
                else
                    Console.WriteLine("There is no department like this!");
            }
        }

        public void EditEmploye(string departmentName, string No,  string newPosition, double newSalary)
        {
            bool isDepHave = false;
            bool isEmpHave = false;
            foreach (Department dep in this.Departments)
            {
                if (dep.Name == departmentName)
                {
                    isDepHave = true;  
                    foreach (Employee worker in dep.Employees)
                    {
                        if (worker.No == No)
                        {

                            worker.Salary = newSalary;
                            worker.Position = newPosition;
                            isEmpHave = true;
                            break;
                        }
                        
                    }
                    break;
                    
                }
            }
            if (!isDepHave)
                Console.WriteLine("There is no department like this!");
            if (!isEmpHave)
                Console.WriteLine("There is no employee like this!");

        }

        public List<string> GetDepartments()
        {
           List<string> DepartmentsName = new List<string>();   

            foreach (Department item in this.Departments)
            {
                string data = $"\nDepartment name : {item.Name}, Employee count : {item.Employees.Count}, Avarage salary : {item.CalcSalaryAverage()}";
                DepartmentsName.Add(data);
            }
            return DepartmentsName;
        }

        public void RemoveEmployee(string departmentName, string No)
        {
            bool isDepHave = false;
            bool isEmpHave = false;
            foreach (Department item in this.Departments)
            {
                if (item.Name == departmentName)
                {
                    isDepHave = true;
                    foreach(Employee worker in item.Employees)
                    {
                        if (worker.No == No)
                        {
                            item.Employees.Remove(worker);
                            isEmpHave = true;
                            break;
                        }
                    }
                    break;  
                }
              
            }
            if (!isDepHave)
                Console.WriteLine("There is no department like this!");
            if (!isEmpHave)
                Console.WriteLine("There is no employee like this!");
        }

        public void PrintAllEmployees()
        {
            foreach(Department item in this.Departments)
            {
                foreach(Employee worker in item.Employees)
                {
                    Console.WriteLine($"No : {worker.No}\nFullname : {worker.FullName}\nPosition : {worker.Position}");
                   
                }
            }
        }

        public void PrintAllEmployeesByDepartment(string depName)
        {
            bool isHave = false;
            foreach (Department item in this.Departments)
            {
                if(item.Name == depName)
                {
                    foreach (Employee worker in item.Employees)
                    {
                        Console.WriteLine($"No : {worker.No}\nFullname : {worker.FullName}\nPosition : {worker.Position}");

                    }
                    isHave = true;
                    break;
                }
            }
            if(!isHave)
                Console.WriteLine("There is no department like this!");
        }
    }
}
