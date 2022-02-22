using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Partice_Problem
{
    internal class UnOrderedLinkedList<T> : LinkedList<T> where T : IComparable
    {
        public static UnOrderedLinkedList<T> List()
        {
            return new UnOrderedLinkedList<T>();
        }

        public new void Append(T data)
        {
            base.Append(data);
        }

      
        public new void Display()
        {
            base.Display();
        }

      
        public new void Add(T data)
        {
            base.Add(data);
        }

        
        public new void Insert(int pos, T data)
        {
            base.Insert(pos, data);
        }

       
        public new void Pop()
        {
            base.Pop();
        }

       
        public new void PopLast()
        {
            base.PopLast();
        }
    }
}