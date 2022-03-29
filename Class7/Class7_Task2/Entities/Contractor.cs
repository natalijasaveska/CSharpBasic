using System;
using System.Collections.Generic;
using System.Text;

namespace Class7_Task2
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour) : base(firstName, lastName, 2500, Role.Contractor)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
    }
}
