using System;

namespace IfElseExercise
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

            if(isTrueNum)
            {
                realNum = inputNum;
                if (realNum % 2 == 0)
                {
                    Console.WriteLine($"{realNum} is even number");
                }
                else
                {
                    Console.WriteLine($"{realNum} is odd number");
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
