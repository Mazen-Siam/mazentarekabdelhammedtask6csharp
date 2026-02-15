using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6csharp
{
    using System;

    
    
        struct Employee
        {
            private int EmpId;
            private string Name;
            private double Salary;

            public Employee(int id, string name, double salary)
            {
                EmpId = id;
                Name = name;
                Salary = salary;
            }

            public string GetName()
            {
                return Name;
            }

            public void SetName(string newName)
            {
                Name = newName;
            }

            public double EmployeeSalary
            {
                get { return Salary; }
                set
                {
                    if (value > 0)
                        Salary = value;
                    else
                        Console.WriteLine("Invalid salary!");
                }
            }

            public void ShowInfo()
            {
                Console.WriteLine($"ID: {EmpId}, Name: {Name}, Salary: {Salary}");
            }
        }
     internal class problem3
    {
        static void Main()
        {
            Employee emp = new Employee(101, "Mazen", 5000);

            Console.WriteLine("Name: " + emp.GetName());
            emp.SetName("Ahmed");

            Console.WriteLine("Salary: " + emp.EmployeeSalary);
            emp.EmployeeSalary = 6000;

            emp.ShowInfo();
        }
    }
}
