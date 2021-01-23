using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        /*
         int ,decimal,float,enum,double,bool are 'value types'
         array, class, interface are 'reference types'
         */
        static void Main(string[] args)
        {
            /*  int number1 = 10;
              int number2 = 30;
              number1 = number2;//number1=30
              number2 = 65;
              Console.WriteLine(number1);//number1=30

              int[] numbers1 = new int[] { 10, 20, 30 };
              int[] numbers2 = new int[] { 100, 200, 300 };
              numbers1 = numbers2;
              numbers2[0] = 999;
              Console.WriteLine(numbers1[0]);
            */

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Yasin";
            person2 = person1;

            person1.FirstName = "Özer";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Osman";
            customer.CreditNumber = "1234567";
            Employee employee = new Employee();

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);


            Console.WriteLine("person3.name : " + person3.FirstName + "customer : " + customer.FirstName + ((Customer)person3).CreditNumber);
            Console.WriteLine("-------------------------------------");
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }

    }

    class Person //base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer :Person
    {
        public string CreditNumber { get; set; }

    }
    class Employee :Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
