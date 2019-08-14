using AdventureWorks.BLL.DTOs;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL.Interfaces;
using System;
using System.Linq;

namespace AdventureWorks.BLL.Services
{
    public class SalesOrderHeaderService : ISalesOrderHeaderService
    {
        private readonly ISalesOrderHeaderRepository _context;

        public SalesOrderHeaderService(ISalesOrderHeaderRepository context)
        {
            _context = context;
        }

        public IQueryable<SalesOrderHeaderDTO> GetAll()
        {
            return _context.GetAll().Select(
                x => new SalesOrderHeaderDTO
                {
                    AccountNumber = x.AccountNumber,
                    CustomerID = x.CustomerID,
                    TotalDue = x.TotalDue
                });
        }

        public SalesOrderHeaderDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
