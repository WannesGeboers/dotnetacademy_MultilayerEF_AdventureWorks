using AdventureWorks.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.BLL.Services.interfaces
{
    public interface ICustomerWithTotalDueService
    {
        CustomerWithTotalDueDTO GetByID(int id);
        IQueryable<CustomerWithTotalDueDTO> GetAll();

    }
}
