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
            OrderedLinkedList<int> orderedList=new OrderedLinkedList<int>();
            Console.WriteLine("Adding 56, 30, 40, 70 to ordered list");
            orderedList.Add(56);
            orderedList.Add(30);
            orderedList.Add(40);
            orderedList.Add(70);

            Console.WriteLine("Sorted List: ");
            orderedList.Display();

            Console.WriteLine("Remove 70");
            orderedList.Remove(70);
            orderedList.Display();
        }
    }
}
