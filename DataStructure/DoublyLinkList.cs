using System;

namespace DataStructure
{
    public class DoublyLinkList<T>
    {
        public DoublyLinkList<T> Next { get; set; }

        public DoublyLinkList<T> Previous { get; set; }

        public T Value { get; set; }

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
}
