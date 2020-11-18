using System;
using System.Collections.Generic;
using DataStructure;

namespace Problems
{
    public class RecentCache
    {
        private readonly Cache cache;
        private readonly Storage storage;

        public RecentCache(int cacheSize, Storage storageInstance)
        {
            this.cache = new Cache(cacheSize);
            this.storage = storageInstance;
        }

        public string GetUserNameByID(int userID)
        {
            string userName = this.cache.Get(userID);

            if (string.IsNullOrEmpty(userName))
            {
                if (this.storage.ContainsKey(userID))
                {
                    UserData userData = this.storage[userID];
                    this.cache.Add(userData);
                    return userData.UserName;
                }
                else
                {
                    return "Not found";
                }
            }

            return userName;
        }
    }

    public class CacheNode<T>
    {
        public CacheNode<T> Next { get; set; }

        public CacheNode<T> Previous { get; set; }

        public T Data { get; set; }
    }

    public class Cache
    {
        private readonly int cacheSize;
        Dictionary<int, CacheNode<UserData>> cachedItems = new Dictionary<int, CacheNode<UserData>>();
        CacheNode<UserData> nodeHead = null;
        CacheNode<UserData> nodeTail = null;

        public Cache(int cacheSize)
        {
            this.cacheSize = cacheSize;
        }

        public override string ToString()
        {
            string data = string.Empty;
            if (nodeHead == null)
            {
                return string.Empty;
            }

            CacheNode<UserData> currentNode = nodeHead;
            do
            {
                data += $"{nodeHead.Data.UserID}->";
            } while (currentNode.Next == null);

            return data;
        }

        public string Get(int userID)
        {
            if (cachedItems.ContainsKey(userID))
            {
                MoveToTop(userID);
            }

            return string.Empty;
        }

        public bool Add(UserData data)
        {
            if (cachedItems.Count < cacheSize)
            {
                AddToCache(data);
            }
            else
            {
                RemoveFromCache();
                AddToCache(data);
            }

            return true;
        }

        private void MoveToTop(int userID)
        {
            CacheNode<UserData> node = cachedItems[userID];

            // Head node so don't need to move further
            if (node.Previous == null)
            {
                return;
            }

            if (node.Next == null)
            {
                // detach
                node.Previous.Next = null;
                node.Previous = null;

                // attach to head
                node.Next = nodeHead;
                nodeHead.Previous = node;
                nodeHead = node;

                return;
            }

            // detach
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            node.Previous = null;
            // attach
            node.Next = nodeHead;
            nodeHead.Previous = node;
            nodeHead = node;
        }

        private void AddToCache(UserData data)
        {
            CacheNode<UserData> newNode = new CacheNode<UserData>
            {
                Data = data
            };

            cachedItems[data.UserID] = newNode;

            if (nodeHead == null && nodeTail == null)
            {
                nodeHead = newNode;
                nodeTail = newNode;
            }
            else
            {
                newNode.Next = nodeHead;
                nodeHead.Previous = newNode;
                nodeHead = newNode;
            }
        }

        private void RemoveFromCache()
        {
            if (nodeTail != null)
            {
                // Having previous node
                if (nodeTail.Previous != null)
                {
                    CacheNode<UserData> previousNode = nodeHead.Previous;
                    previousNode.Next = null;
                    nodeTail.Previous = null;
                    cachedItems.Remove(nodeTail.Data.UserID);
                    nodeTail = previousNode;
                }
                // Tail node and Head node is same
                else
                {
                    cachedItems.Remove(nodeTail.Data.UserID);
                    nodeTail = null;
                    nodeHead = null;
                }
            }
        }
    }

    public class Storage : Dictionary<int, UserData>
    {

    }

    public class UserData
    {
        public int UserID { get; set; }

        public string UserName { get; set; }
    }
}