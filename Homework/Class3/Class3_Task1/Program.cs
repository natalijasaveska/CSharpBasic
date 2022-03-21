using System;

namespace Class3_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integersArray = new int[6];
            int sum = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                string number = Console.ReadLine();
                bool success = int.TryParse(number, out int parsedNumber);
                if (success)
                {
                    integersArray[i] = parsedNumber;

                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            foreach (int integer in integersArray)
            {
                if (integer % 2 == 0)
                {
                    sum += integer;
                }
            }
            Console.WriteLine($"The sum of all even integers in the array is {sum}");
        }
    }
}
