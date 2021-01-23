using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> myList = new MyList<string>();
            Console.WriteLine("sayac_start : " + myList.Count);
            myList.Add("Asiye");
            myList.Add("Asiye2");
            myList.Add("Asiye3");
            myList.Add("Asiye4");

             Console.WriteLine("sayac_finish : " + myList.Count);
            /*
            List<string> names1 = new List<string>(); 
            MyList<string> names = new MyList<string>();
            names.Add("Salah");
            Console.WriteLine("Hello World!");
            names.Add("ali");
            Console.WriteLine(names.Lenght);



            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
