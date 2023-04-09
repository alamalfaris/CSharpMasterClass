using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memberss
{
    class Member
    {
        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        //member - public field
        public int age;

        //member - property
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //member - method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharePrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hello my name is {memberName} {age} years old, my job is {jobTitle}");
            }
        }

        private void SharePrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        //member - constructor
        public Member()
        {
            memberName = "Andi";
            jobTitle = "C# Developer";
            age = 26;
            salary = 50000;
            Console.WriteLine("Member created!");
        }

        //member - finalizer / deconstructure
        ~Member()
        {
            //cleanup statement
            Console.WriteLine("Deconstructure of member object");
        }
    }
}
