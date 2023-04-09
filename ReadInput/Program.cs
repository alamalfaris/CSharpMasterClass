using System;

namespace ReadInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string and press enter:");
            string readInput = Console.ReadLine();
            Console.WriteLine($"You have entered {readInput}");

            Console.WriteLine("Enter the string and press enter:");
            int asciiInput = Console.Read();
            Console.WriteLine($"ASCII input is {asciiInput}");
        }
    }
}
