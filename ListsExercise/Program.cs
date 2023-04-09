using System;
using System.Collections.Generic;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNum = Solution();            
        }

        public static List<int> Solution()
        {
            // TODO: write your solution here
            List<int> listNumber = new List<int>();

            for (int i = 100; i <= 170; i += 2)
            {
                listNumber.Add(i);
            }

            return listNumber;
        }
    }
}
