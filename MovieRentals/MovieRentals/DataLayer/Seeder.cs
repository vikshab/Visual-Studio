using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using MovieRentals.Models;

namespace MovieRentals.DataLayer
{
    public class Seeder
    {
        public static void SeedMovies()
        {
            // Read the contents of the file
            string s = File.ReadAllText("..\\..\\..\\MovieRentals\\App_Data\\movies.json");

            // Parse the contents using JSON.NET
            JArray data = (JArray)JsonConvert.DeserializeObject(s);

            MovieRepository repository = new MovieRepository();
            int indexNumber = 1;

            // Process the data
            foreach (JToken token in data)
            {
                Movie m = new Movie();
                m.Id = indexNumber;
                m.Title = token["title"].Value<string>();
                m.Overview = token["overview"].Value<string>();
                m.ReleaseDate = token["release_date"].Value<string>();
                m.Inventory = token["inventory"].Value<int>();

                repository.Add(m);
                indexNumber++;
            }
        }

        public static void SeedCustomers()
        {
            // Read the contents of the file
            string s = File.ReadAllText("..\\..\\..\\MovieRentals\\App_Data\\customers.json");

            // Parse the contents using JSON.NET
            JArray data = (JArray)JsonConvert.DeserializeObject(s);

            CustomerRepository repository = new CustomerRepository();

            // Process the data
            foreach (JToken token in data)
            {
                Customer c = new Customer();
                c.Id = token["id"].Value<int>();
                c.Name = token["name"].Value<string>();
                c.RegisteredAt = token["registered_at"].Value<string>();
                c.Address = token["address"].Value<string>();
                c.City = token["city"].Value<string>();
                c.State = token["state"].Value<string>();
                c.PostalCode = token["postal_code"].Value<string>();
                c.Phone = token["phone"].Value<string>();
                c.AccountCredit = token["account_credit"].Value<decimal>();

                repository.Add(c);
            }
        }

        public static void SeedRentals()
        {
            // Read the contents of the file
            string s = File.ReadAllText("..\\..\\..\\MovieRentals\\App_Data\\rentals.json");

            // Parse the contents using JSON.NET
            JArray data = (JArray)JsonConvert.DeserializeObject(s);

            RentalRepository repository = new RentalRepository();
            int indexNumber = 1;

            // Process the data
            foreach (JToken token in data)
            {
                Rental r = new Rental();
                r.Id = indexNumber;
                r.CheckoutDate = token["checkout_date"].Value<string>();
                r.ReturnedDate = token["returned_date"].Value<string>();
                r.RentalTime = token["rental_time"].Value<string>();
                r.Cost = token["cost"].Value<string>();
                r.Total = token["total"].Value<string>();
                r.CustomerId = token["customer_id"].Value<int>();
                r.MovieId = token["movie_id"].Value<int>();
                repository.Add(r);
                indexNumber++;
            }
        }
    }
}