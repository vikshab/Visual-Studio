using MovieRentals.DataLayer;
using MovieRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieRentals.Controllers
{
    public class RentalsController : ApiController
    {
        // GET api/rentals
        public IEnumerable<Rental> Get()
        {
            RentalRepository r = new RentalRepository();
            return r.GetAll();
        }

        // GET api/rentals/5
        public Rental Get(int id)
        {
            RentalRepository r = new RentalRepository();
            return r.Find(id);
        }


        // POST: api/Rentals
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Rentals/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Rentals/5
        public void Delete(int id)
        {
        }
    }
}
