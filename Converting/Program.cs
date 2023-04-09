using System;

namespace Converting
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int myInt = 120;
            long myLong = myInt;
            Console.WriteLine(myLong);

            //explicit conversion
            double myDouble = 15.55;
            int myDoubleInt = (int)myDouble;
            Console.WriteLine(myDoubleInt);

            //type conversion
            string myString = myDouble.ToString();
            Console.WriteLine(myString);
            bool isTrue = false;
            string isTrueString = isTrue.ToString();
            Console.WriteLine(isTrueString);

            //assignment-1
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int
            float floatForString = float.Parse(stringForFloat);
            int intForString = Int32.Parse(stringForInt);
            Console.WriteLine(floatForString);
            Console.WriteLine(intForString);
        }
    }
}
