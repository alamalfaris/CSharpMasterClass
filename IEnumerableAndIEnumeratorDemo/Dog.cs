using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumeratorDemo
{
    class Dog
    {
        public string Name { get; set; }
        public bool IsNaugthy { get; set; }

        public Dog(string name, bool isNaugthy)
        {
            Name = name;
            IsNaugthy = isNaugthy;
        }
    }
}
