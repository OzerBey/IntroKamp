using System;
using System.Collections.Generic;
using System.Text;

namespace RecapPlayerDemo.Entities
{
    class Player:Customer
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

    }
}
