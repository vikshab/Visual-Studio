using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentals.Models
{
    interface IRentalRepository
    {
        Rental Find(int id);
        List<Rental> GetAll();
        void Add(Rental rental);
        Rental Update(Rental rental);
        void Remove(int id);
        void Save(Rental rental);
    }
}
