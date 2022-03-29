using System;

namespace Class7_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] company = {
                new Contractor("Jack","Johnson",139.5,20),
                new Contractor("Noah","Williams",141,20),
                new Manager("Sophia","Miller"),
                new Manager("Emma","Garcia"),
                new SalesPerson("Oliver","Taylor")
            };


            CEO firstCeo = new CEO("Jacob", "Davies", company, 100);

            firstCeo.PrintCEOInfo();

        }
    }
}
