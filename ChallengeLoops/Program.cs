using System;

namespace ChallengeLoops
{
    class Program
    {
        // Algorithm
        // - try parse dulu
        // -- kalo bukan angka print "Invalid input"
        // -- kalo angka, cek dia angka berapa
        // --- kalo angka -1 calculasi break
        // --- kalo angka range 0 - 20 dia di sum
        // --- kalo selain angka2 di atas, "Score must be 0 - 20"

        static int totalScore = 0;
        static int n = 0;
        static void Main(string[] args)
        {
            CalculateScore();
        }

        public static void CalculateScore()
        {
            bool stillCalculate = true;
            while (stillCalculate)
            {
                Console.WriteLine("Please enter the score: ");
                string inputScore = Console.ReadLine();
                int score;
                bool isValidInput = int.TryParse(inputScore, out score);
                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    if (score >= 0 && score <= 20)
                    {
                        totalScore += score;
                        n++;
                    }
                    else if (score == -1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Score must be 0 - 20");
                    }
                }
            }

            int averageScore = totalScore / n;
            Console.WriteLine($"Average score is {averageScore}");
        }
    }
}
