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
        IEnumerable<CustomerWithTotalDueDTO> FilterByTotalDue(char c, decimal number);
        IEnumerable<CustomerWithTotalDueDTO> FilterByFirstName(string name);
        IEnumerable<CustomerWithTotalDueDTO> FilterByLastName(string name);
        IEnumerable<CustomerWithTotalDueDTO> FilterByAccountNumber(string name);

        IEnumerable<CustomerWithTotalDueDTO> FilterByStringAndAttribute(string search, string attribute);
    }
}
