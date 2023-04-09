using System;

namespace HelloWorld
{
    public class Program
    {
        //static int age;

        public static void Main(string[] args)
        {
            //age = 20;
            sbyte x = 127;
            short y = 32767;
            int q = 2147483647;
            long j = 9223372036854775807;
            
            float g = 99.99f;
            double d = 999.999; //more precision than float
            decimal c = 9999.9999m; //more precision than double

            bool isTrue = true;

            char singleLetter = 'a';
            string username = "jason1998";
            string title;
            title = "Holy God";

            int num3, num4, num5;

            float f1 = 3.1f;
            float f2 = 4.5f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1 / f2 = " + fDiv);

            double d1 = 3.1;
            double d2 = 4.5;
            double dDiv = d1 / d2;
            Console.WriteLine("d1 / d2 = " + dDiv);

            
            decimal e1 = 3.1m;
            decimal e2 = 4.5m;
            decimal eDiv = e1 / e2;
            Console.WriteLine("e1 / e2 = " + eDiv);

            string name = "Alam";
            string message = "My name is " + name;
            bool isContain = message.Contains("kambing");
            Console.WriteLine(message);
            Console.WriteLine(isContain);

            SayHello();
        }

        /// <summary>
        /// Give u WriteLine("Hellooo")
        /// </summary>
        public static void SayHello()
        {
            Console.WriteLine("Hellooo Welcome");
            Console.Write("Hello");
            Console.Write("Welcome");
        }
    }
}
