
using EmployeeProgram;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        ABank bank = new ABank();
        bank.AddDepartment("Programming", 5, 500);
        bank.AddDepartment("HumanResource", 5, 400);
        bank.AddEmployee("HumanResource", "Ferid Elizade","C# developer",500);
        bank.AddEmployee("Programming", "Vusal Memmedli", "C# developer", 700);
        bank.AddEmployee("Programming", "Ilkin Zeynaov", "C# developer", 600);
        bank.AddEmployee("Programming", "Sevil Mirzeyeva", "C# developer", 550);



        while (true)
        {
            Console.WriteLine("\n1.1 Departamentlerin siyahisi");
            Console.WriteLine("1.2 Departament yarat ");
            Console.WriteLine("1.3 Departament deyisiklik et ");
            Console.WriteLine("2.1 Iscilerin siyahisi");
            Console.WriteLine("2.2 Departamentdeki iscilerim siyahisi");
            Console.WriteLine("2.3 Isci elave et");
            Console.WriteLine("2.4 Isci uzerinde deyisiklik et");
            Console.WriteLine("2.5 Departamentden isci sil");

            Console.Write("\nEmeliyyatin nomresi : ");
            string enter = Console.ReadLine();


            switch (enter)
            {
                case "1.1":
                    foreach(string item in bank.GetDepartments())
                    {
                        Console.WriteLine(item);    
                    }
                    break;
                case "1.2":
                    {
                        Console.Write("Departament adi : ");
                        string depName = Console.ReadLine();
                        Console.Write("Isci limit : ");
                        int wLimit = int.Parse(Console.ReadLine());
                        Console.Write("Maas limiti : ");
                        double sLimit = double.Parse(Console.ReadLine());

                        bank.AddDepartment(depName, wLimit, sLimit);
                    }
                   
                    break;
                  
                case "1.3":
                    {
                        Console.Write("Departament adi : ");
                        string depName = Console.ReadLine();
                        Console.Write("Yeni Departament adi : ");
                        string newDepName = Console.ReadLine();

                        bank.EditDepartments(depName, newDepName);
                    }

                    break;

                case "2.1":
                    {
                        bank.PrintAllEmployees();
                    }
                    break;
                case "2.2":
                    {
                        Console.Write("Departament adi : ");
                        string depName = Console.ReadLine();

                        bank.PrintAllEmployeesByDepartment(depName);
                    }
                    break;
                case "2.3":
                    {
                        Console.Write("Departament adi : ");
                        string depName = Console.ReadLine();
                        Console.Write("Isci adi : ");
                        string fullName = Console.ReadLine();
                        Console.Write("Isci vezifesi : ");
                        string position = Console.ReadLine();
                        Console.Write("Maas limiti : ");
                        double salaryLimit = double.Parse(Console.ReadLine());

                        bank.AddEmployee(depName, fullName, position, salaryLimit);
                    }
                    break;
                case "2.4":
                    {
                        Console.Write("Departament adi : ");
                        string depName = Console.ReadLine();
                        Console.Write("No : ");
                        string no = Console.ReadLine();
                        Console.Write("Positon : ");
                        string position = Console.ReadLine();
                        Console.Write("Salary : ");
                        double salary = double.Parse(Console.ReadLine());

                        bank.EditEmploye(depName,no,position,salary);
                        
                    }
                    break;

                case "2.5":
                    {
                        Console.Write("Departament adi : ");
                        string depName = Console.ReadLine();
                        Console.Write("No : ");
                        string no = Console.ReadLine();

                        bank.RemoveEmployee(depName, no);
                    }
                  
                    break;

                default:
                    Console.WriteLine("Bele bi emeliyyat yoxdur!");
                    break;
            }
            if (enter == "exit")
                break;
        }
     
    }
}