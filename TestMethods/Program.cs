using System;

namespace TestMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }

        public static string LowUpper(string text)
        {
            string lowerText = text.ToLower();
            string upperText = text.ToUpper();
            return String.Concat(lowerText, upperText);
        }

        public static void Count(string text)
        {
            int lengthText = text.Length;
            Console.WriteLine($"The amount of characters is {lengthText}");
        }
    }
}
