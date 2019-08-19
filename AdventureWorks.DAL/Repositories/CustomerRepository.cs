using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private  AWContext _context { get; }


        public CustomerRepository(AWContext context)
        {
            //nullcheck
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        


        public Customer GetByID(int id)
        {
            return
                _context.Customers
                .Include("Person")
                .Include("SalesOrderHeaders")
                .Where(x => x.CustomerID == id)
                //firstOrDefault zou bij eventuele dubbels fouten kunnen geven
                //maar een id zou geen dubbele waarden mogen bevatten                
                .SingleOrDefault();

        }

        public IQueryable<Customer> GetAll()
        {            
            var customers = 
                _context.Customers
                .Include("Person")
                .Include("SalesOrderHeaders");            
            return customers;
        }
    }
}
