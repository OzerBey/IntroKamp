using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager.Save(new Customer() {Id=1, DateOfBirth=new DateTime(1998,5,15),FirstName="Yasin",LastName="Özer",NationalityId="36811456195"});
            
        
        }
    }
}
