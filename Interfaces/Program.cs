using System;

namespace Interfaces // katmanlar arası geçişlerde daha sık kullanılır 
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[] 
            { 
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MysqlServerCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            IPerson person = new Customer() { Id = 1, FirstName = "Yasin" };
            person.LastName = "Özer";
            var result = person.FirstName;
            Console.WriteLine(result);

            PersonManager personManager = new PersonManager(person);
            personManager.Add();
        }
    }

    interface IPerson // soyut nesne
    {
        int Id { get; set; } // sadece imza şeklinde yzaılır public yazılmaz
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson // somut nesne
    {
        private string _firstName;
        public int Id { get; set; } // sadece imza şeklinde yzaılır public yazılmaz
        public string FirstName
        {
            get
            {
                return "Mr." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student : IPerson // somut nesne
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get; set; }

    }
    class Worker : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class PersonManager
    {
        IPerson _person;
        public PersonManager(IPerson person1)
        {
            _person = person1;
        }
        public void Add()
        {
            Console.WriteLine(_person.FirstName + " Added !!");
        }
    }
}
