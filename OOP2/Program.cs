using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer() {Id=1, CustomerNumber="12345",FirstName="Yasin",LastName="Özer"};
            CoorporateCustomer customer2 = new CoorporateCustomer() {Id=2, CustomerNumber="54321",CompanyName="Özer A.ş",TaxNumber="123456789"};

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




        }
    }
}
