using System.Linq;

namespace AdventureWorks.DAL.Interfaces
{
    public interface IPersonRepository
    {
        Person GetByID(int id);
        IQueryable<Person> GetAll();

    }
}
