using System;

namespace DataStructure
{
    public class SinglyLinkList<T>
    {
        SingleNode<T> head;

        public void Push(T data)
        {
            SingleNode<T> newNode = head == null ? new() { Data = data } : new() { Data = data, Next = head };
            head = newNode;
        }

        public void Append(T data)
        {
            if (head == null)
            {
                SingleNode<T> newNode = new() { Data = data };
                head = newNode;
            }
            else
            {
                SingleNode<T> newNode = new() { Data = data };
                Tail().Next = newNode;
            }
        }

        public SingleNode<T> Tail()
        {
            if (head == null)
            {
                return null;
            }
            else
            {
                var currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode;
            }
        }

        public SingleNode<T> RemoveTail()
        {
            if (head == null)
            {
                return null;
            }
            else if (head.Next == null)
            {
                var nodeToRemove = head;
                head = null;
                return nodeToRemove;
            }
            else
            {
                var previousNode = head;
                var currentNode = head.Next;
                while (currentNode.Next != null)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }

                previousNode.Next = null;
                return currentNode;
            }
        }
    }

    public class SingleNode<T>
    {
        public SingleNode<T> Next { get; set; }

        public T Data { get; set; }
    }
}
