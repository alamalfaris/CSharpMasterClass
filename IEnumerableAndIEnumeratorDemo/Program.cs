using System;

namespace IEnumerableAndIEnumeratorDemo
{
    class Program
    {
        //1. IEnumerable<T> for generic collection
        //2. IEnumerable for non generic collection

        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            foreach (Dog dog in shelter.dogs)
            {
                Console.WriteLine(dog.Name);
            }
        }
    }
}
