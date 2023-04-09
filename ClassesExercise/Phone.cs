using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your constructors
        // default constructor
        public Phone()
        {
            this.Company = "unknown";
            this.Model = "unknown";
            this.ReleaseDay = "unknown";
        }
        // parameterized constructor
        public Phone(string Company, string Model)
        {
            this.Company = Company;
            this.Model = Model;
            this.ReleaseDay = "unknown";
        }
        // parameterized constructor
        public Phone(string Company, string Model, string ReleaseDay)
        {
            this.Company = Company;
            this.Model = Model;
            this.ReleaseDay = ReleaseDay;
        }

        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }
    }
}
