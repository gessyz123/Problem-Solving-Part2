using System;
using System.Collections.Generic;

namespace LRU_Cache
{
    public class Node
    {
        public int key;
        public int value;
        public Node Previous;
        public Node Next;

    }
    public class LRUCache
    {
        Node Head;
        Node Tail;
        Dictionary<int, Node> Cache = new Dictionary<int, Node>();
        int Capacity;
        int size;

        public LRUCache(int capacity)
        {
            Capacity = capacity;
            Head = new Node();
            Tail = new Node();

            Head.Next = Tail;
            Tail.Previous = Head;
            size = 0;

        }

        private void AddNode(Node node)
        {
            node.Previous = Head;
            node.Next = Head.Next;

            Head.Next.Previous = node;
            Head.Next = node;

            if (Tail.Previous == Head)
            {
                Tail.Previous = node;
            }
            
        }

        private void DeleteNode(Node node)
        {
            Node prev= node.Previous;
            Node next = node.Next;

            prev.Next = node.Next;
            next.Previous = node.Previous;

        }
        // to remove the least used element 

        public Node PopTail()
        {
            Node removed = Tail.Previous;
            DeleteNode(removed);
            return removed;
        }
        // move the most recently called node to the front 

        public void MoveToHead(Node node)
        {

            
            DeleteNode(node);
            AddNode(node);

        }
        public int get(int x)
        {
            Node node;

            if (!Cache.ContainsKey(x)) return -1;
            else
                node = Cache[x];  

            return node.value;
        }

        public void set(int x, int y)
        {

            Node node;

            if (!Cache.ContainsKey(x))
            {
                node = new Node
                {
                    key = x,
                    value = y
                };
                if (size < Capacity)
                {

                    ++size;
                    Cache.Add(x, node);
                    AddNode(node);
                }
                else
                {
                   new Node { 
                        key = x,
                        value = y
                    };
                    Node tail = PopTail();
                    Cache.Remove(tail.key);
                    Cache.Add(x, node);
                    --size;
                }
            }
            else
            {
                node = Cache[x];
                node.value = y;
                Cache[x] = node;
               MoveToHead(node);
                
            }
        
          
        }
        static void Main(string[] args)
        {
            LRUCache cache = new LRUCache(3);
            cache.set(1, 10);
            cache.set(2, 20);
            cache.set(3, 30);

            Console.WriteLine(cache.get(1));
        
            cache.set(1, 100);

            Console.WriteLine(cache.get(1));
          
            cache.set(4, 40);
            Console.WriteLine(cache.get(1));
            /*
            Console.WriteLine(cache.get(1));
            Console.WriteLine(cache.get(2));
            Console.WriteLine(cache.get(3));
            Console.WriteLine(cache.get(4));
       */




        }

    }
}
