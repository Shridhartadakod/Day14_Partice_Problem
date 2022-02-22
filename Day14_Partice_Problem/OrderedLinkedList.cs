using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Partice_Problem
{
    internal class OrderedLinkedList<T> : LinkedList<T> where T : IComparable
    {
     
        public new void Add(T data)
        {
            int index = 0;
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.data.CompareTo(data) > 0)
                    break;
                temp = temp.next;
                index++;
            }
            Insert(index, data);
        }

        public new void Pop()
        {
            base.Pop();
        }

 
        public static OrderedLinkedList<T> OrderedList()
        {
            return new OrderedLinkedList<T>();
        }

    }
}
