using System;
using System.Linq;
using System.Collections.Generic;

namespace Question5
{
    class Employee
    {
        int emp_id;
        string Emp_Name;
        int Emp_Salary;
        string Emp_Department;
        static void Main(string[] args)
        {
            List<Employee> e = new List<Employee>()
    {
        new Employee{emp_id = 11, Emp_Name = "Rahul",
                Emp_Salary = 50000,Emp_Department = "HR"},
        new Employee{emp_id = 12, Emp_Name = "Poonam",
                Emp_Salary = 65000,Emp_Department = "Techinal"},
        new Employee{emp_id = 13, Emp_Name = "Priya",
                Emp_Salary = 45000,Emp_Department = "TR"},
        new Employee{emp_id = 14, Emp_Name = "Raj",
                Emp_Salary = 20000,Emp_Department = "HR"},
        new Employee{emp_id = 15, Emp_Name = "Shivam",
                Emp_Salary = 70000,Emp_Department = "Technical"},
        new Employee{emp_id = 16, Emp_Name = "Shubham",
                Emp_Salary = 40000,Emp_Department = "TR"},
    };
            var result_set = e.Where(emp => emp.Emp_Department == "HR").OrderByDescending(
                                        sal => sal.Emp_Salary);
            foreach (Employee emp in result_set)
            {
                Console.WriteLine(emp.emp_id + " " +
                                emp.Emp_Name + " " +
                                emp.Emp_Salary + " " +
                                emp.Emp_Department);
            }
        }
    }
}

