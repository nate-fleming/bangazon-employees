using System;

namespace employeeExercise
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string first, string last, string title, DateTime date)
        {
            FirstName = first;
            LastName = last;
            Title = title;
            StartDate = date;
        }
    }
}