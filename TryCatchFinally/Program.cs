using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");
            string numString = Console.ReadLine();

            try
            {
                int num = int.Parse(numString);
                Console.WriteLine("Input correct");
            }
            catch(FormatException)
            {
                Console.WriteLine("Format exception");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow exception");
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }
        }
    }
}
