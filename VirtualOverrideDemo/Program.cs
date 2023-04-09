using System;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myLovelyCat = new Cat("Kitty", 1);
            myLovelyCat.MakeSound();
            myLovelyCat.Play();
            myLovelyCat.Eat();
        }
    }
}
