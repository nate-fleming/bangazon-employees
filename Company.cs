using System;
using System.Collections.Generic;

namespace employeeExercise
{
    class Company
    {
        public DateTime DateFounded { get; set; }
        public string CompanyName { get; set; }
        public List<Employee> Employees { get; set; }

        public Company(string name, DateTime date)
        {
            CompanyName = name;
            DateFounded = date;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {CompanyName} as {employee.Title} since {employee.StartDate}");
            }
        }
    }
}