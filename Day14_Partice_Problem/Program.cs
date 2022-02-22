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
            UnOrderedLinkedList<int> list=new UnOrderedLinkedList<int>();
            Console.WriteLine("Appending 56, 70 to list");
            list.Append(56);
            list.Append(70);
            list.Display();

            Console.WriteLine("\nInserting 30 at pos 1");
            list.Insert(1, 30);

            Console.WriteLine("Pop from list");
            list.Pop();


            Console.WriteLine("List 1");
            list.Display();
        }
    }
}
