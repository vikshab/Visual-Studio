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
    public class MoviesController : ApiController
    {
        // GET api/movies
        public IEnumerable<Movie> Get()
        {
            MovieRepository r = new MovieRepository();
            return r.GetAll();
        }

        // GET api/movies/5
        public Movie Get(int id)
        {
            MovieRepository r = new MovieRepository();
            return r.Find(id);
        }

        // POST: api/Movies
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Movies/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Movies/5
        public void Delete(int id)
        {
        }
    }
}
