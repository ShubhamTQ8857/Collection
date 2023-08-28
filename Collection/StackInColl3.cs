using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class StackInColl3
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);


            stack.Pop(); // remove the top element
            // Peek() -- returns the top element in the stack
            Console.WriteLine("Top element " + stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

    }
}
