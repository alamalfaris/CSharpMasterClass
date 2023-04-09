using System;

namespace ChallengeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Debby";
            string friend2 = "Tasya";
            string friend3 = "Maulidya";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine($"Hi {name}, my friend!");
        }
    }
}
