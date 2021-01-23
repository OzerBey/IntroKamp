using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Yasin");
            myDictionary.Add(2, "Özer");
            myDictionary.Add(2, "Ali");
            myDictionary.Add(2, "Zeynep Nur");

            Console.WriteLine("Count: " +myDictionary.Count);

            foreach (var values in myDictionary.Values)
            {
                Console.WriteLine("values:" + values);
            }



        }
    }
}
