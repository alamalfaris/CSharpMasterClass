using System;

namespace ChallengeIfStatement2
{
    class Program
    {
        static int tempHighScore;
        static string tempPlayerName;
        static void Main(string[] args)
        {
            Console.WriteLine("Input player name with highscore so far: ");
            tempPlayerName = Console.ReadLine();
            Console.WriteLine("Input highscore so far: ");
            string tempHighScoreString = Console.ReadLine();
            tempHighScore = int.Parse(tempHighScoreString);

            Console.WriteLine("Please input player name: ");
            string inputPlayerName = Console.ReadLine();
            Console.WriteLine("Please input player score: ");
            string inputScoreString = Console.ReadLine();
            int inputScore = int.Parse(inputScoreString);

            //call method
            Scoring(inputScore, inputPlayerName);
        }

        public static void Scoring(int score, string playerName)
        {
            if (score > tempHighScore)
            {
                Console.WriteLine($"New highscore is {score}");
                Console.WriteLine($"New highscore holder is {playerName}");
            }
            else
            {
                Console.WriteLine($"The old highscore of {tempHighScore} could not be broken and is still held by {tempPlayerName}");
            }
        }
    }
}
