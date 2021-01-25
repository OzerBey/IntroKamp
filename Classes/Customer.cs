using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //Encapsulation
        private string _firstName;
        public int Id { get; set; }
        public string FirstName
        {
            get
            {
                return "Mr." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        //Auto property
        public string City { get; set; }

    }
}
