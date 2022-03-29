using System;
using System.Collections.Generic;
using System.Text;

namespace Class7_Task2
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _sharesPrice { get; set; }

        public CEO(string firstName, string lastName, Employee[] employees, int shares) : base(firstName,lastName,0,Role.CEO)
        {
            Employees = employees;
            Shares = shares;
        }

        public double AddSharesPrice(double sharesPrice)
        {
            _sharesPrice = sharesPrice;
            return _sharesPrice;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("*Employees:");
            foreach (Employee employee in Employees)
            {
                employee.PrintInfo();
            }
        }
        public override double GetSalary()
        {
            Salary += Shares * _sharesPrice;
            return Salary;
        }

        public void PrintCEOInfo()
        {
            {
                Console.WriteLine("*CEO:");
                AddSharesPrice(45);
                PrintInfo();
                Console.WriteLine($"*Salary of CEO {GetSalary()}$");
               PrintEmployees();
            };
        }
    }
}

