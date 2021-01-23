using System;
using System.Collections.Generic;

namespace Collections
{
    class Program  
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"Yasin","Özer","Ali","Osman" };
            Console.WriteLine(names[0]);

            List<string> names2 = new List<string>() { "Yasin", "Özer", "Ali", "Osman" } ;
            names2.Add("Azer");
 
        }
    }
}
