using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer2 = new Customer() { Id=1,FirstName="Yasin",City="İstanbul",LastName="Özer"};
            Customer customer1 = new Customer(5,"","","");
            Console.WriteLine(customer2.FirstName+" "+ customer2.City);

        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Constructor");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
