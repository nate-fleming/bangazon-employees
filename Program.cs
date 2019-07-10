using System;

namespace employeeExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var dm = new Company("Dunder Mifflin", new DateTime(1 / 5 / 14));

            var creed = new Employee("Creed", "Bratton", "QA Rep", new DateTime());
            var kelly = new Employee("Kelly", "Kapoor", "Customer Service Rep", new DateTime(2004, 4, 4));
            var kevin = new Employee("Kevin", "Malone", "Accountant", new DateTime(1999, 4, 4));

            dm.AddEmployee(creed);
            dm.AddEmployee(kelly);
            dm.AddEmployee(kevin);

            dm.ListEmployees();
        }
    }
}
