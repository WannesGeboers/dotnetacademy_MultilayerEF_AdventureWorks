using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.DAL.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetByID(int id);
        IQueryable<Customer> GetAll();

    }
}
