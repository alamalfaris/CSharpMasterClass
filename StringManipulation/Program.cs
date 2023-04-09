using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 31;
            string name = "Johnson";
            string job = "Developer";

            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I'm " + age + " years old");

            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I'm {1} years old. My job is {2}", name, age, job);

            Console.WriteLine("String interpolation");
            Console.WriteLine($"Hello my name is {name}, I'm {age} years old");
        }
    }
}
