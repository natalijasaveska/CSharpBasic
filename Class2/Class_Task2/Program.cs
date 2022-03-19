using System;

namespace Class_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers:");
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();

            bool firstCheck = int.TryParse(numberOne, out int firstNum);
            bool secondCheck = int.TryParse(numberTwo, out int secondNum);

            if (firstCheck && secondCheck && firstNum != 0 && secondNum != 0)
            {
                Console.WriteLine($"First number is: {firstNum}, Second number is: {secondNum}");
                firstNum = firstNum * secondNum;
                secondNum = firstNum / secondNum;
                firstNum = firstNum / secondNum;

                Console.WriteLine($"First number is: {firstNum}, Second number is: {secondNum}");
            }
            else if (firstNum <= 0 || secondNum <= 0)
            {
                Console.WriteLine("Invalid inputs.You should enter a number. That number should be > than 0.");
            }
        }
    }
}
