using System;

namespace Class7_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee firstManager = new Employee("Savannah", "Hurtado", 2000, Role.Manager);
            firstManager.PrintInfo();


            Employee firstSalesPerson = new Employee("Nathaniel", "Brandon", 1000, Role.Sales);
            firstSalesPerson.PrintInfo();
        

            Contractor firstContractor = new Contractor("LJ","Smith",0,127.5,20,new Employee("Spencer","Montgomery",2350,Role.ContractorManager));
            firstContractor.GetSalary();
            firstContractor.PrintInfo();
            firstContractor.CurrentPosition();

        }
    }
}
