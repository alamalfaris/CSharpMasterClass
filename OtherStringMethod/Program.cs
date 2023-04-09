using System;

namespace OtherStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Alam";
            string lastName = "Alfaris";
            string fullName = string.Concat(" ", firstName, lastName, " ");
            Console.WriteLine(fullName);
            Console.WriteLine(firstName.Substring(1));
            Console.WriteLine(firstName.ToLower());
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(firstName.IndexOf('m'));
            Console.WriteLine(String.IsNullOrWhiteSpace(fullName));
            Console.WriteLine(String.Format("My name is {0} {1}", firstName, lastName));
        }
    }
}
