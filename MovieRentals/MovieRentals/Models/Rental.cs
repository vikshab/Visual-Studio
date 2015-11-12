using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public string CheckoutDate { get; set; }
        public string ReturnedDate { get; set; }
        public string RentalTime { get; set; }
        public string Cost { get; set; }
        public string Total { get; set; }
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
    }
}