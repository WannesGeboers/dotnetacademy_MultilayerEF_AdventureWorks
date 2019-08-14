using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL.Repositories
{
    public class SalesOrderHeaderRepository : ISalesOrderHeaderRepository
    {
        private readonly ISalesOrderHeaderRepository _context;

        public SalesOrderHeaderRepository(ISalesOrderHeaderRepository context)
        {
            _context = context;
        }
        public IQueryable<SalesOrderHeader> GetAll()
        {
            return _context.GetAll()
                .Select(x => new SalesOrderHeader
                {//more properties are out of scope
                    AccountNumber=x.AccountNumber,
                    TotalDue=x.TotalDue,
                    Customer=x.Customer
                });
        }

        public SalesOrderHeader GetByID(int id)
        {
            return _context.GetByID(id);
        }
    }
}
