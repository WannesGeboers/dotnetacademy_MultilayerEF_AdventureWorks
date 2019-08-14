using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.BLL.Services.interfaces
{
    public interface ICustomerService
    {
        CustomerDTO GetByID(int id);
        IQueryable<CustomerDTO> GetAll();

    }
}
