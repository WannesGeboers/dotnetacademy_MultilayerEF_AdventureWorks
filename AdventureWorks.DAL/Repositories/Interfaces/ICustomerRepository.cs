using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetByID(int id);
        IQueryable<Customer> GetAll();

    }
}
