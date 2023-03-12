using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace EmployeeProgram
{
    public interface IHumanResourceManager
    {
    
       public List<Department> Departments { get; set; }

        public void AddDepartment(string name, int wLimit, double sLimit);

        public List<string> GetDepartments();

        public void EditDepartments(string departmentName, string newDepartmentName);

        public void AddEmployee(string departmentName, string fullname, string position, double salary);

        public void RemoveEmployee(string departmentName, string No);

        public void EditEmploye(string departmentName, string No, string newPosition, double newSalary);
        
    }
}
