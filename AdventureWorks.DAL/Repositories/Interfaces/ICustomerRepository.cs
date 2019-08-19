using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.DAL.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetByID(int id);
       
        IQueryable<Customer> GetAll();
        IEnumerable<Customer> FilterByFirstName(string name);
        IEnumerable<Customer> FilterByLastName(string name);
        IEnumerable<Customer> FilterByAccountNumber(string name);
        IEnumerable<Customer> FilterByStringAndAttribute(string search, string attribute);

    }
}
