using System;

namespace InheritanceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thank you for the gifts", "alamalfaris", true);            
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("This is my new car", "sukapamerdotcom", true, "https://image.com");
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Cianjur earthquake", "tvonenews", true, "https://videonews.com", 76);
            Console.WriteLine(videoPost1.ToString());
        }
    }
}
