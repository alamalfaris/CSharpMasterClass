using System;

namespace ChallengeString1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            
            Console.WriteLine("Please enter your name and press enter:");
            inputString = Console.ReadLine(); //tutorials.eu

            Console.WriteLine(inputString.ToUpper()); //TUTORIALS.EU
            Console.WriteLine(inputString.ToLower()); //tutorials.eu
            Console.WriteLine(inputString.Trim()); //tutorials.eu
            Console.WriteLine(inputString.Substring(0, 4));
        }
    }
}
