using System;
using System.Collections.Generic;

namespace StacksInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining a new stack
            Stack<int> stack = new Stack<int>();
            // add elements to the stack using push
            stack.Push(1);
            stack.Push(3);
            // Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is {0}", stack.Peek()); // 3

            // Pop() will return the element at the top of the stack with removing it
            Console.WriteLine("Top value in the stack is {0}", stack.Pop()); // 3
            Console.WriteLine("Top value in the stack is {0}", stack.Peek()); // 1 because 3 was removed

            int[] numbers = { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> numberStack = new Stack<int>();

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
                numberStack.Push(number);
            }

            Console.WriteLine("");

            while (numberStack.Count > 0)
            {
                Console.Write(numberStack.Pop() + " ");
            }
        }
    }
}
