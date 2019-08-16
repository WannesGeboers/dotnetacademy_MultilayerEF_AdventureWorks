using AdventureWorks.BLL.DTOs;
using System.Linq;

namespace AdventureWorks.BLL.Services.interfaces
{
    public interface ISalesOrderHeaderService
    {
        SalesOrderHeaderDTO GetByID(int id);
        IQueryable<SalesOrderHeaderDTO> GetAll();
    }
}
