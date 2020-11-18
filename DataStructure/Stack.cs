using System;

namespace DataStructure
{
    public class Stack<T>
    {
        SinglyLinkList<T> stack = new();

        public void Push(T item)
        {
            stack.Push(item);
        }

        public T Pull()
        {
            return stack.RemoveTail().Data;
        }
    }
}