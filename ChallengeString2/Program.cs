using System;

namespace ChallengeString2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            char inputKey;
            
            Console.WriteLine("Enter a string here: ");
            inputString = Console.ReadLine();
            
            Console.WriteLine("Enter the character to search: ");
            inputKey = Console.ReadLine()[0];

            int charIndex = inputString.IndexOf(inputKey) + 1;
            Console.WriteLine($"Character {inputKey} is character ke-{charIndex} from {inputString}");

            Console.WriteLine("-------------------------");

            string firstName;
            string lastName;

            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();

            string fullName = String.Concat(firstName, " ", lastName);
            Console.WriteLine($"Your full name is {fullName}");
        }
    }
}
