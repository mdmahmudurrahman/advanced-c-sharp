using System;
using System.Collections.Generic;

namespace _6_delegate_improvement_to_the_previous_codes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Mahmud", Salary = 10000, Experience = 1 });
            employees.Add(new Employee { Id = 2, Name = "Jamal", Salary = 10000, Experience = 1 });
            employees.Add(new Employee { Id = 3, Name = "Kamal", Salary = 20000, Experience = 3 });
            employees.Add(new Employee { Id = 4, Name = "Jon", Salary = 10000, Experience = 3 });         

            Employee employee = new Employee();
            employee.PromoteEmployee(employees, emp => emp.Experience > 2);

            Console.ReadKey();
        }

    }

    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public void PromoteEmployee(List<Employee> employees, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employees)
            {
                if (IsEligibleToPromote(employee))
                    Console.WriteLine(employee.Name + " is promoted");
            }
        }
    }
}
