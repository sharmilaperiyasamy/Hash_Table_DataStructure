using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    internal class MyMapNode<K, V>
    {
        LinkedList<KeyValue<K, V>> list = new LinkedList<KeyValue<K, V>>();
        public void add(K key, V value)
        {
            KeyValue<K, V> kv = new KeyValue<K, V>() { key = key, value = value };
            list.AddLast(kv);
        }
        public void getFrequency()
        {
            int count = 0;
            if (list == null)
            {
                Console.WriteLine("Hash Table is empty.");
                return;
            }
            foreach (KeyValue<K, V> item in list)
            {
                foreach (KeyValue<K, V> value in list)
                {
                    if (item.value.Equals(value.value))
                        count++;
                }
                Console.WriteLine("Count of " + item.value + " is " + count);
                count = 0;
            }
        }
    }
    public struct KeyValue<K, V>
    {
        public K key;
        public V value;
    }
}
