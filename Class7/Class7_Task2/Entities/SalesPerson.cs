using System;
using System.Collections.Generic;
using System.Text;

namespace Class7_Task2
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue;

        public SalesPerson(string firstName, string lastName) : base(firstName, lastName, 500, Role.Sales)
        {

        }

        public void AddSuccessRevenue(double successSaleRevenue)
        {
            _successSaleRevenue = successSaleRevenue;
        }

        public override double GetSalary()
        {
            int bonus = 0;
            if (_successSaleRevenue <= 2000) bonus = 500;
            if (_successSaleRevenue > 2000 || _successSaleRevenue < 5000) bonus = 1000;
            if (_successSaleRevenue > 5000) bonus = 1500;

            return Salary + bonus;

        }
    }
}
