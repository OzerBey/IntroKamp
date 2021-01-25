using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Adapters
{
    class MernisServiceAdapter:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //
            return true;
        }
    }
}
