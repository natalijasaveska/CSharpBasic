using System;
using System.Collections.Generic;
using System.Text;

namespace Class7_Task1
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Employee Responsible { get; set; }

        public Contractor(string firstName, string lastName,double salary,double workHours, int payPerHour,Employee responsibleEmployee) : base(firstName, lastName,salary,Role.Contractor)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsibleEmployee;
        }


        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary; 
        }

        public void CurrentPosition()
        {
            Console.WriteLine($"{Responsible.FirstName} {Responsible.LastName} is responsible ({Responsible.Role}) for (of) the {Role}, {FirstName} {LastName}");
        }

    }
}
