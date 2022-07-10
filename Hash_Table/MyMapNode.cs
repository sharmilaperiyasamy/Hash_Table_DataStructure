using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class MyMapNode<K, V>
    {
        int size;
        LinkedList<KeyValue<K, V>>[] list;
        public MyMapNode(int size)
        {
            this.size = size;
            this.list = new LinkedList<KeyValue<K, V>>[size];
        }

        public void add(K key, V value)
        {
            int index = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> newList = getLinkedList(index);
            KeyValue<K, V> kv = new KeyValue<K, V>() { key = key, value = value };
            newList.AddLast(kv);
        }
        public int getFrequency(string value)
        {
            int count = 0;
            if (list == null)
            {
                Console.WriteLine("Hash Table is empty.");
                return 0;
            }
            for (int i = 0; i < list.Length; i++)
            {
                LinkedList<KeyValue<K, V>> newList = getLinkedList(i);
                foreach (KeyValue<K, V> items in newList)
                {
                    if (items.value.Equals(value))
                        count++;
                }
            }
            Console.WriteLine("Count of " + value + " is " + count);
            return count;
        }
public void Remove(K key)
{
    int position = GetArrayPosition(key);
    LinkedList<KeyValue<K, V>> linkedList = getLinkedList(position);
    bool itemFound = false;
    KeyValue<K, V> foundItem = default(KeyValue<K, V>);
    foreach (KeyValue<K, V> item in linkedList)
    {
        if (item.key.Equals(key))
        {
            itemFound = true;
            foundItem = item;
        }
    }
    if (itemFound)
    {
        linkedList.Remove(foundItem);
    }
}
public int GetArrayPosition(K key)
{
    int index = key.GetHashCode() % size;
    return Math.Abs(index);
}
public LinkedList<KeyValue<K, V>> getLinkedList(int index)
{
    LinkedList<KeyValue<K, V>> newList = list[index];
    if (newList == null)
    {
        newList = new LinkedList<KeyValue<K, V>>();
        list[index] = newList;
    }
    return newList;
}
public bool ContainsKey(K key)
{
    int position = GetArrayPosition(key);
    LinkedList<KeyValue<K, V>> linkedList = getLinkedList(position);
    foreach (KeyValue<K, V> item in linkedList)
    {
        if (item.key.Equals(key))
        {
            return true;
        }
    }
    return false;
}
public V GetValue(K key)
{
    int position = GetArrayPosition(key);
    LinkedList<KeyValue<K, V>> linkedList = getLinkedList(position);
    foreach (KeyValue<K, V> item in linkedList)
    {
        if (item.key.Equals(key))
        {
            return item.value;
        }
    }
    return default(V);
}
    }
    public struct KeyValue<K, V>
    {
        public K key;
        public V value;
    }
}
