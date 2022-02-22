using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Partice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StackList<int> stack = new StackList<int>();
            Console.WriteLine("Pushing to stack:");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

            while(stack.IsEmpty() is false)
            {
                Console.WriteLine("top element: " +stack.Peek());
                Console.WriteLine("Popping");
                stack.Pop();
                Console.WriteLine("List:");
                stack.Display();
            }
        }
    }
}
