using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentals.Models
{
    public interface ICustomerRepository
    {
        Customer Find(int id);
        List<Customer> GetAll();
        void Add(Customer customer);
        Customer Update(Customer customer);
        void Remove(int id);
        void Save(Customer customer);
    }
}
