using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL.Interfaces
{
    public interface ISalesOrderHeaderRepository
    {
        SalesOrderHeader GetByID(int id);
        IQueryable<SalesOrderHeader> GetAll();
    }
}
