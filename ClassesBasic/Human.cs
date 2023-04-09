using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasic
{
    /*kalo public berarti si object itu bisa diakses dari luar class human ini,
         kalo private berarti object itu gak bisa di akses dari luar class human,
        mau variable atau method sama aja*/

    public class Human
    {
        //member variable
        private string firstname;
        private string lastname;
        private string eyeColor;
        private int age;

        //default contructor
        public Human()
        {
            Console.WriteLine("Constructor called, object created!");
        }

        //parameterized constructor
        public Human(string firstname, string myLastname, string eyeColor, int age) 
        {
            this.firstname = firstname; //kalo nama variable nya sama, yang global variable pake "this."
            lastname = myLastname;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human(string firstname, string myLastname, string eyeColor)
        {
            this.firstname = firstname; //kalo nama variable nya sama, yang global variable pake "this."
            lastname = myLastname;
            this.eyeColor = eyeColor;
        }

        //member method
        public void IntroduceMyself()
        {
            if (age != 0)
            {
                Console.WriteLine($"Haloo my name is {firstname} {lastname} {age} years old. My eye color is {eyeColor}");
            }
            else
            {
                Console.WriteLine($"Haloo my name is {firstname} {lastname}. My eye color is {eyeColor}");
            }
        }
    }
}
