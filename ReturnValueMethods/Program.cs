using System;

namespace ReturnValueMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(10, 20);
            Console.WriteLine(result);

            double result2 = Devide(15, 4);
            Console.WriteLine(result2);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
