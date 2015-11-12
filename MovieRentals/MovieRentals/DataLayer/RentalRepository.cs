using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Html;
//using MovieRentals.Interfaces;
using MovieRentals.Models;
using Dapper;

namespace MovieRentals.DataLayer
{
    public class RentalRepository
    {
        private SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\AdaRockstar\Source\Repos\Visual-Studio\MovieRentals\MovieRentals\App_Data\VideoStore.mdf;Integrated Security=True");
        public Rental Find(int id)
        {
            var dbArgs = new DynamicParameters();
            dbArgs.Add("id", id);

            return this.db.Query<Rental>("select * from rentals where id=@id", dbArgs).First();
        }

        public List<Rental> GetAll()
        {
            return this.db.Query<Rental>("select * from rentals").ToList();
        }

        public void Add(Rental rental)

       
        {
            db.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    "insert into rentals (id, CheckoutDate, ReturnedDate, Cost, Total, CustomerId, MovieId) values (@id, @checkout_date, @returned_date, @cost, @total, @customer_id, @movie_id)",
                    this.db);
                command.Parameters.AddWithValue("@id", rental.Id);
                command.Parameters.AddWithValue("@checkout_date", rental.CheckoutDate);
                command.Parameters.AddWithValue("@returned_date", rental.ReturnedDate);
                command.Parameters.AddWithValue("@cost", rental.Cost);
                command.Parameters.AddWithValue("@total", rental.Total);
                command.Parameters.AddWithValue("@customer_id", rental.CustomerId);
                command.Parameters.AddWithValue("@movie_id", rental.MovieId);

                command.ExecuteNonQuery();
            }
            finally
            {
                db.Close();
            }
        }

        public Rental Update(Rental rental)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Movie GetFullMovie(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}