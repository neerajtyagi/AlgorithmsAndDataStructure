using System;

namespace DS
{
    public class DS_DoublyLinkList<T>
    {
        public DS_DoublyLinkList<T> Next { get; set; }  

        public DS_DoublyLinkList<T> Previous { get; set; }

        public T Value { get; set; } 
    }
}
