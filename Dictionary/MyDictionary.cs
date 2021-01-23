using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T, V>
    {
        T[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new V[0];
        }

        public void Add(T key, V value)
        {
            T[] tempKey = keys;
            V[] tempValue = values;
            keys = new T[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            for (int j = 0; j < keys.Length; j++)
            {
                if (key == null)
                {
                    Console.WriteLine("Key can't be null");
                }
                else if (keys[j].Equals(key))
                {
                    Console.WriteLine("Already exist in array");
                }
            }
            keys[keys.Length - 1] = key; values[values.Length - 1] = value;
        }

        public int Count
        {
            get { return keys.Length; }

        }

        public T[] Keys
        {
            get { return keys; }
        }

        public V[] Values
        {
            get { return values; }
        }
 
        /*
               public void getAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + ": " + values[i]);
            }
        }
         */
    }
}
