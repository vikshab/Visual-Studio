using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalsAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string ReleaseDate { get; set; }
        public int Inventory { get; set; }
    }
}