using System;

namespace Class2_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");

            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter and choose the operation: +, -, *, or /");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("You've chosen addition");
                    Console.WriteLine($"Sum = {firstNumber + secondNumber}");
                    break;

                case "-":
                    Console.WriteLine("You've chosen subtraction");
                    Console.WriteLine($"Difference = {firstNumber - secondNumber}");
                    break;

                case "*":
                    Console.WriteLine("You've chosen multiplying");
                    Console.WriteLine($"Product = {firstNumber * secondNumber}");
                    break;

                case "/":
                    Console.WriteLine("You've chosen division");
                    Console.WriteLine($"Quotient = {firstNumber / secondNumber}");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
