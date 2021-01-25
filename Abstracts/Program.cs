using System;

namespace Abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ManagerClass managerClass = new ManagerClass();
            managerClass.Add();
            managerClass.AbstractDeneme();
        }
    }

    class ManagerClass : MyAbstractClass
    {
        public override void Add()
        {
            Console.WriteLine("Manager class added");
        }
    }

    abstract class MyAbstractClass
    {
        abstract public void Add();

        public void AbstractDeneme()
        {
            Console.WriteLine("abstarct dneme");
        }
    }
}
