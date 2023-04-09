using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Height = -10;
            box.Width = 10;
            box.SetLength(10);
            Console.WriteLine($"Box length {box.GetLength()}");
            Console.WriteLine($"Box volume {box.Volume}");
            Console.WriteLine($"Box width {box.Width}");
            Console.WriteLine($"Box front surface {box.FrontSurface}");

            Box box2 = new Box(6, 6, 6);
            Console.WriteLine($"Box2 length {box2.GetLength()}");
            Console.WriteLine($"Box2 volume {box2.Volume}");
            Console.WriteLine($"Box2 width {box2.Width}");
        }
    }
}
