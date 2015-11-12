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
    public class CustomersController : ApiController
    {
        // GET api/customers
        public IEnumerable<Customer> Get()
        {
            CustomerRepository r = new CustomerRepository();
            return r.GetAll();
        }

        // GET api/customers/5
        public Customer Get(int id)
        {
            CustomerRepository r = new CustomerRepository();
            return r.Find(id);
        }

        // POST: api/Customers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
    }
}
