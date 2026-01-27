using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_stack_queue_hashmap
{
    internal class CustomHashMap
    {
        private readonly int SIZE = 100;
        private LinkedList<KeyValuePair<int, int>>[] buckets;

        public CustomHashMap()
        {
            buckets = new LinkedList<KeyValuePair<int, int>>[SIZE];
        }

        private int Hash(int key)
        {
            return key % SIZE;
        }

        // Insert or Update
        public void Put(int key, int value)
        {
            int index = Hash(key);

            if (buckets[index] == null)
                buckets[index] = new LinkedList<KeyValuePair<int, int>>();

            foreach (var pair in buckets[index])
            {
                if (pair.Key == key)
                {
                    buckets[index].Remove(pair);
                    buckets[index].AddLast(new KeyValuePair<int, int>(key, value));
                    return;
                }
            }

            buckets[index].AddLast(new KeyValuePair<int, int>(key, value));
        }

        // Retrieve
        public int Get(int key)
        {
            int index = Hash(key);

            if (buckets[index] != null)
            {
                foreach (var pair in buckets[index])
                {
                    if (pair.Key == key)
                    {
                        return pair.Value;
                    }
                        
                }
            }
            return -1; // Not found
        }

        // Delete
        public void Remove(int key)
        {
            int index = Hash(key);

            if (buckets[index] != null)
            {
                foreach (var pair in buckets[index])
                {
                    if (pair.Key == key)
                    {
                        buckets[index].Remove(pair);
                        return;
                    }
                }
            }
        }
    }
}
