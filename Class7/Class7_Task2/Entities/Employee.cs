using System;
using System.Collections.Generic;
using System.Text;

namespace Class7_Task2
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public Role Role { get; set; }

        public Employee(string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}, Salary:{Salary}$, Role: {Role} ");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
