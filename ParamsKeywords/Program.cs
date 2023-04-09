using System;

namespace ParamsKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintWords("halo", "namaku", "alam"); //kalo gak dikasi keyword params, pasti bakal error

            int[] numbers = { 2, 34, 15, 9, 55, 4 };
            int result = MinValue(numbers);
            Console.WriteLine($"Min value from this array is {result}");
        }

        public static void PrintWords(params string[] arrayWord)
        {
            foreach (string word in arrayWord)
            {
                Console.WriteLine(word);
            }
        }

        public static int MinValue(params int[] numbers)
        {
            int num = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < num)
                {
                    num = number;
                }
            }

            return num;
        }
    }
}
