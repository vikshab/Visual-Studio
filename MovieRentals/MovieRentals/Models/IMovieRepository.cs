using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentals.Models
{
    interface IMovieRepository
    {
        Movie Find(int id);
        List<Movie> GetAll();
        void Add(Movie movie);
        Movie Update(Movie movie);
        void Remove(int id);
        Movie GetFullMovie(int id);
        void Save(Movie movie);
    }
}
