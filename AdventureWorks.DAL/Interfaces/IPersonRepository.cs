using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL.Interfaces
{
    public interface IPersonRepository
    {
        Person GetByID(int id);
        IQueryable<Person> GetAll();

    }
}
