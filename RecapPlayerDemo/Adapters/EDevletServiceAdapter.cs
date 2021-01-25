using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Abstract;
using RecapPlayerDemo.Entities;

namespace RecapPlayerDemo.Adapters
{
    class EDevletServiceAdapter : Customer, ICustomerCheckManager
    {
        private Customer _player;
        public EDevletServiceAdapter(Customer player)
        {
            _player = player;
        }
        public bool CheckIfRealPerson(Customer player)
        {
            if (player.Id == 0) //simulasyon
            {
                Console.WriteLine("There is no such user !!1");
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
