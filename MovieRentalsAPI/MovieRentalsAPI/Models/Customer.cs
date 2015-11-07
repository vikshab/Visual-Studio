using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MovieRentalsAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegisteredAt { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public float AccountCredit { get; set; }
    }
}
