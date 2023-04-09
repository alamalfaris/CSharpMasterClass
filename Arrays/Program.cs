using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 12;
            grades[2] = 3;
            grades[3] = 7;
            grades[4] = 17;

            Console.WriteLine($"Grades at index 0 : {grades[0]}");

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine($"Grades at index 0 : {grades[0]}");

            //way to declare array-1
            int[] gradesStudent1 = { 9, 10, 7, 6 };

            //way to declare array-2
            int[] gradesStudent2 = new int[] { 6, 6, 10, 9 , 9};

            Console.WriteLine($"Length of grade student 1: {gradesStudent1.Length}");
            Console.WriteLine($"Length of grade student 2: {gradesStudent2.Length}");
        }
    }
}
