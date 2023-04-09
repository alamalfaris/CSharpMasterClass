using System;

namespace ArrayForForeachExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);
        }

        public static void GetOdd(int[] Array)
        {
            // TODO
            foreach (var i in Array)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void GetEven(int[] Array)
        {
            // TODO
            foreach (var i in Array)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
