using System;
using System.Collections.Generic;
using System.Text;
using RecapPlayerDemo.Abstract;

namespace RecapPlayerDemo.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int DateOfBirth { get; set; }
    }
}
