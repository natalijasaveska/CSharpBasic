using System;
using System.Collections.Generic;
using System.Text;

namespace Class7_Task2
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName) : base(firstName, lastName,2000,Role.Manager)
        {
            
        }
    }
}
