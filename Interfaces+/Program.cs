using System;

namespace InterfacesPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler new'lenemez!!
            IPersonManager personManager = new CustomerManager();
            personManager.Add();

            IPersonManager personManager1 = new EmployeeManager();
            personManager1.Add();

            Console.WriteLine("------------------------------");
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

            
        }
    }
    interface IPersonManager
    {
        //implemented operation
        void Add(); //interfaceler zaten dışarıdan erişilebilir (public) o yüzden public yazılmaz
        void Update();
    }

    //inherits (miras alır) -class --------------- interface - implements(implement eder)
    class CustomerManager : IPersonManager
    { 
        public void Add()
        {
            Console.WriteLine("Customer added");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee added");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("intern added");
        }

        public void Update()
        {
            Console.WriteLine("intern updated");
        }
    }

    class ProjectManager 
    {
        public void Add(IPersonManager person)
        {
            person.Add();
        }

    }

}
