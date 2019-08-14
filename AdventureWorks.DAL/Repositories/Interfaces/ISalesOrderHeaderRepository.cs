using System.Linq;

namespace AdventureWorks.DAL.Interfaces
{
    public interface ISalesOrderHeaderRepository
    {
        SalesOrderHeader GetByID(int id);
        IQueryable<SalesOrderHeader> GetAll();
    }
}
