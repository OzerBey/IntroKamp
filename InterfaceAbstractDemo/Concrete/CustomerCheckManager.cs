﻿using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService

    {
        public bool CheckIfRealPerson(Customer customer)
        {

            return true;
        }

    }
}
