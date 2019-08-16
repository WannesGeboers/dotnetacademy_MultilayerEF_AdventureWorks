using AdventureWorks.BLL.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.BLL.Services.interfaces
{
    public interface ICustomerService
    {
        CustomerWithTotalDueDTO GetCustomerWithTotalDue(int id);
        IEnumerable<CustomerWithTotalDueDTO> GetAllCustomersWithTotalDue();
        IEnumerable<CustomerWithTotalDueDTO> GetAllCustomersAverage(char c);
        IEnumerable<CustomerWithTotalDueDTO> GetByTotalDue(char c, decimal number);
    }
}
