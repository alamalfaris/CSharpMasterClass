using System;

namespace IfTernaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int temprature = -5;
            string statements;

            //if (temprature < 0)
            //{
            //    statements = "Freeze";
            //}
            //else
            //{
            //    statements = "Not Freeze";
            //}

            //ternary expression
            statements = temprature < 0 ? "solid" : "liquid";
            Console.WriteLine($"state is {statements}");
            temprature += 20;
            statements = temprature < 0 ? "solid" : "liquid";
            Console.WriteLine($"state is {statements}");
            temprature += 100;
            statements = temprature > 100 ? "gas" : temprature < 0 ? "solid" : "liquid";
            Console.WriteLine($"state is {statements}");
        }
    }
}
