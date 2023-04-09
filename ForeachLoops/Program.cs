using System;

namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            //for (int j = 0; j < nums.Length; j++)
            //{
            //    Console.WriteLine($"Element{j} = {nums[j]}");
            //}

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine($"Element{counter} = {k}");
                counter++;
            }

            string[] myFriends = new string[5];
            myFriends[0] = "Dena";
            myFriends[1] = "Tri";
            myFriends[2] = "Candra";
            myFriends[3] = "Jefry";
            myFriends[4] = "Rafid";

            foreach (var friend in myFriends)
            {
                Console.WriteLine($"Haloo {friend}, apa kabarmu?");
            }
        }
    }
}
