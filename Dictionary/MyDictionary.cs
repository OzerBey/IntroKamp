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
            keys[keys.Length - 1] = key; values[values.Length - 1] = value;
        }

        public int Count
        {
            get { return keys.Length; }

        }

        public V[] Values
        {
            get { return values; }
        }
    }
}
