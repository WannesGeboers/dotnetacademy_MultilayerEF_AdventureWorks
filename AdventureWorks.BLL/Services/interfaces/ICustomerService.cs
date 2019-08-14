using System.Linq;

namespace AdventureWorks.BLL.Services.interfaces
{
    public interface ICustomerService
    {
        CustomerDTO GetByID(int id);
        IQueryable<CustomerDTO> GetAll();

    }
}
