using System;

namespace ClassesBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Human alam = new Human("Alam", "Alfaris", "Brown", 22); //create object 1
            alam.IntroduceMyself();

            Human ardi = new Human("Ardiansyah", "Fakhrul", "Blue"); //create object 2
            ardi.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();
        }
    }
}
