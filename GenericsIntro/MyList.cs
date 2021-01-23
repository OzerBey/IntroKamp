using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Type :T
    {
        T[] items;

        public MyList()
        {
            items = new T[0]; //instance for items array
        }

        public void Add(T element)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1]; //++

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = element;
        }

        public int Count
        {
            get { return items.Length; }
            }
        }




        /*
        T[] items; //must be same type with class
        //Constructor :   ctor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T element)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = element;
        }

        public int Lenght // read-only property
        {
            get
            {
                return items.Length;
            }
        }

        public T[] Items
        {
            get { return items;}
        }

        */
    }

