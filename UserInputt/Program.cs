using System;

namespace UserInputt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number: ");
            string num1String = Console.ReadLine();
            Console.WriteLine("Please enter the second number: ");
            string num2String = Console.ReadLine();

            int num1 = int.Parse(num1String);
            int num2 = int.Parse(num2String);

            return num1 + num2;
        }
    }
}
