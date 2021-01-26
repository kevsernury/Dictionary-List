using System;
using System.Collections.Generic;
using System.Text;

namespace DictonaryLists
{
    class MyList<K,V>
    {
        Items[] list = new Items[0];
        Items[] tempList;

        public void Add(K key, V value)
        {
            Items item = new Items(key, value);
            tempList = list;
            list = new Items[list.Length + 1];

            for (int i = 0; i < tempList.Length; i++)
            {
                list[i] = tempList[i];
            }

            list[list.Length - 1] = item;
        }

        public void ShowList()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].key + " " + list[i].value);
            }
        }

        public void ShowByKey(K key)
        {
            for (int i = 0; i < list.Length; i++)
            {
                K temp = (K)list[i].key;
                if (temp.Equals(key))
                {
                    Console.WriteLine((V)list[i].value);
                }
                
            }
        }
    }

    class Items
    {
        public Object key { get; set; }
        public Object value { get; set; }
        public Items(Object key, Object value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
