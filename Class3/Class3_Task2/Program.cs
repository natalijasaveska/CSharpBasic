using System;

namespace Class3_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsGroupOne = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsGroupTwo = new string[5] { "Zoki", "Mile", "Brus", "Petko", "Vele" };

            Console.WriteLine("Choose a group. Enter a number between 1 and 2.");
            string number = Console.ReadLine();
            bool success = int.TryParse(number, out int parsedNumber);

            if (success)
            {
                switch (parsedNumber)
                {
                    case 1:
                        Console.WriteLine(" G1-students:");
                        foreach (string name in studentsGroupOne)
                        {
                            Console.WriteLine(name);
                        }
                        break;

                    case 2:
                        Console.WriteLine(" G2-students:");
                        foreach (string name in studentsGroupTwo)
                        {
                            Console.WriteLine(name);
                        }
                        break;

                    default:
                        Console.WriteLine("The number you've entered is not 1 or 2.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }
        }
    }
}
