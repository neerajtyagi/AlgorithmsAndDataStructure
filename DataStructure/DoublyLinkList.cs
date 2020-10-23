using System;

namespace DataStructure
{
    public class DoublyLinkList<T>
    {
        public DoublyLinkList<T> Next { get; set; }  

        public DoublyLinkList<T> Previous { get; set; }

        public T Value { get; set; } 
    }
}
