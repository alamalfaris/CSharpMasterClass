using System;

namespace NestedIfExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");
            string numString = Console.ReadLine();

            int inputNum;
            int realNum;
            bool isTrueNum = int.TryParse(numString, out inputNum);

            if (isTrueNum)
            {
                realNum = inputNum;
                if (realNum % 3 == 0)
                {
                    Console.WriteLine("Divisible by 3.");
                }
                else if (realNum % 7 == 0)
                {
                    Console.WriteLine("Divisible by 7.");
                }
                else if (realNum % 2 != 0)
                {
                    Console.WriteLine("Odd number.");
                }
                else
                {
                    Console.WriteLine("Even number");
                }
            }
            else
            {
                inputNum = 0;
                Console.WriteLine("Your input is not a number");
            }
        }
    }
}
