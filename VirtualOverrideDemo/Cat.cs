using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Cat : Animal
    {
        public bool IsHappy { get; set; }
        public Cat(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }
        public override void Eat()
        {
            // meng-override tapi isinya tetep sama dengan method parent
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meaowww");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
