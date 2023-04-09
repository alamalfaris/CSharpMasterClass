using System;

namespace BreakContinueExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -10;

            while (i < 10)
            {

                // TODO
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i++);
            }
        }
    }
}
