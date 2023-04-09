using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumeratorDemo
{
    class DogShelter
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Helly", false),
                new Dog("Pixel", true),
                new Dog("Romman", false)
            };
        }
    }
}
