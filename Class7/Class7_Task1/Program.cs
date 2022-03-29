using System;

namespace Class7_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Employee("Savannah", "Hurtado", 2000, Role.Manager);
            manager.PrintInfo();

            Employee sales = new Employee("Nathaniel", "Brandon", 1000, Role.Sales);
            sales.PrintInfo();
        
            Contractor contractor = new Contractor("LJ","Smith",0,127.5,20,new Employee("Spencer","Montgomery",2350,Role.ContractorManager));
            contractor.GetSalary();
            contractor.PrintInfo();
            contractor.CurrentPosition();

        }
    }
}
