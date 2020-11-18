using System;

namespace DataStructure
{
    public class DoublyLinkList<T>
    {
        DoubleNode<T> head, tail;

        public bool AddFirst(T data)
        {
            throw new NotImplementedException("Not yet implemented");
        }

        public bool AddLast(T data)
        {
            throw new NotImplementedException("Not yet implemented");
        }

        public T GetFirst()
        {
            throw new NotImplementedException("Not yet implemented");
        }

        public T GetLast()
        {
            throw new NotImplementedException("Not yet implemented");
        }

        public T RemoveFirst()
        {
            throw new NotImplementedException("Not yet implemented");
        }

        public T RemoveLast()
        {
            throw new NotImplementedException("Not yet implemented");
        }
    }

    public class DoubleNode<T>
    {
        public DoubleNode<T> Next { get; set; }

        public DoubleNode<T> Previous { get; set; }
        public T Data { get; set; }
    }
}
