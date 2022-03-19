using System;

namespace Class2_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four numbers:");
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();
            string numberThree = Console.ReadLine();
            string numberFour = Console.ReadLine();
            int sum;
            int average;

            bool firstCheck = int.TryParse(numberOne, out int firstNum);
            bool secondCheck = int.TryParse(numberTwo, out int secondNum);
            bool thirdCheck = int.TryParse(numberThree, out int thirdNum);
            bool fourthCheck = int.TryParse(numberFour, out int fourthNum);

            if (firstCheck && secondCheck && thirdCheck && fourthCheck)
            {
                sum = firstNum + secondNum + thirdNum + fourthNum;
                Console.WriteLine($"The sum of the inputs is {sum}");
                if (sum != 0)
                {
                    average = sum / 4;
                    Console.WriteLine($"The average value of the inputs is {average}");
                }
                else
                {
                    Console.WriteLine("The sum of the four inputs is 0");
                }
            }
            else
            {
                Console.WriteLine("Invalid input/s");
            }
        }
    }
}
