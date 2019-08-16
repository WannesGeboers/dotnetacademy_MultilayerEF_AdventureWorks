using AdventureWorks.DAL.Interfaces;
using System.Linq;

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
                    AccountNumber = x.AccountNumber,
                    TotalDue = x.TotalDue,
                    Customer = x.Customer
                });
        }

        public SalesOrderHeader GetByID(int id)
        {
            return _context.GetByID(id);
        }

        public decimal TotalDueByCustomerID(int id)
        {
            return _context.GetAll()
                .Where(x => x.CustomerID == id)
                .Select(x => x.TotalDue)
                .Sum();
        }
    }
}
