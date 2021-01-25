
using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Concrete
{
   public class StarbucksCustomerManager :BaseCustomerManager,ICustomerCheckService
   {

       private ICustomerCheckService _customerCheckService;

       public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
       {
           _customerCheckService = customerCheckService;
       }

       public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public override void Save(Customer customer) //Base class
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }

            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
