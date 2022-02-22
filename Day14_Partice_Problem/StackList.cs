using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Partice_Problem
{
    internal class StackList<T>:LinkedList<T> where T:IComparable
    {
        public static StackList<T> Stack()
        {
            return new StackList<T>();
        }

        public void Push(T data)
        {
            Add (data);
        }
    }
}
