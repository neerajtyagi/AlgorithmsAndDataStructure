using System;
using System.Linq;
using System.Collections.Generic;

namespace DataStructure
{
    public class CircularSortedLinkList<T> where T : IComparable
    {
        private CircularSortedLinkList()
        {
        }

        public CircularSortedLinkList(T value)
        {
            this.Value = value;
            this.Next = this;
        }
        public T Value { get; set; }

        public CircularSortedLinkList<T> Next { get; set; }

        public void Add(T value)
        {
            CircularSortedLinkList<T> currentNode = this;

            while (true)
            {
                if (currentNode.Next == this /* Only single node available */
                || currentNode.Value.CompareTo(value) == 0 /* Current node value equals to new value */
                || (currentNode.Value.CompareTo(value) < 0  /* Current node is less than new value */
                    && (currentNode.Next.Value.CompareTo(value) > 0 /* next mode is greater that value */
                    || currentNode.Next.Value.CompareTo(currentNode.Value) < 0)) /* next node is less than current value */
                || (currentNode.Value.CompareTo(value) > 0 && currentNode.Next.Value.CompareTo(currentNode.Value) < 0))
                {
                    CircularSortedLinkList<T> newNode = new CircularSortedLinkList<T> { Value = value, Next = currentNode.Next };
                    currentNode.Next = newNode;
                    break;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }

        /// Convert list into flat array
        public T[] ToArray()
        {
            List<T> list = new List<T>();

            CircularSortedLinkList<T> currentNode = this;
            list.Add(currentNode.Value);

            while (currentNode.Next != this)
            {
                currentNode = currentNode.Next;
                list.Add(currentNode.Value);
            }

            return list.ToArray();
        }
    }
}