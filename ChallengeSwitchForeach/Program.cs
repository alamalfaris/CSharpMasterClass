using System;

namespace ChallengeSwitchForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            string inputValueType;

            Console.Write("Enter a value:");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.Write("Enter:");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    //check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    //check for integer
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool retBool = false;
                    //check for boolean
                    valid = bool.TryParse(inputValue, out retBool);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "Unknown";
                    Console.WriteLine("Not able to detect the input type, wrong input type");
                    break;
            }

            Console.WriteLine($"Your input value is: {inputValue}");
            if (valid)
            {
                Console.WriteLine($"It is valid: {inputValueType}");
            }
            else
            {
                Console.WriteLine($"It is invalid: {inputValueType}");
            }
        }

        static bool IsAllAlphabetic(string value)
        {
            foreach (var c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }                
            }
            return true;
        }
    }
}
