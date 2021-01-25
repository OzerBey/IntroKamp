using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo.Abstract
{
    interface ICustomerCheckManager
    {
        bool CheckIfRealPerson(Customer player);

    }
}
