using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo.Abstract
{
    interface ICustomerManager
    {
        void Add(Customer player);
        void Update(Customer player);
        void Delete(Customer player,int id); 
        void ShowList(Customer[] players);
    }
}
