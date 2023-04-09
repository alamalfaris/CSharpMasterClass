using System;

namespace ChallengeIfTernary
{
    class Program
    {
        static void Main(string[] args)
        {
            TempratureCheck();
        }

        public static void TempratureCheck()
        {
            Console.WriteLine("Please enter the temprature degree: ");
            string stringTemprature = Console.ReadLine();
            int temprature;
            string tempratureStatement;
            bool isValidTemprature = int.TryParse(stringTemprature, out temprature);

            if (!isValidTemprature)
            {
                Console.WriteLine("Not a valid temprature");
            }
            else
            {
                //ternary
                tempratureStatement = temprature <= 15 ? "it is too cold here" : temprature >= 16 && temprature <= 28 ? "it is ok" : "it is hot here";
                Console.WriteLine($"Statement is {tempratureStatement}");
            }
        }
    }
}
