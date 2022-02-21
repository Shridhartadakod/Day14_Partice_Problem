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
            Console.WriteLine("Adding 56,30,70");
            list.Append(56);
            list.Append(30);
            list.Append(70);
            Console.WriteLine("list_1");
            list.Display();
        }
    }
}
