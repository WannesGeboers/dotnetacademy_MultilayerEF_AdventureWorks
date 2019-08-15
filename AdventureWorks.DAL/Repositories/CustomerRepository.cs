using AdventureWorks.DAL.Interfaces;
using System;
using System.Linq;

namespace AdventureWorks.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private AWContext _context { get; set; }


        public CustomerRepository(AWContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        //public IQueryable GetAll()
        //{
        //    
        //}

        public Customer GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Customer> GetAll()
        {
            return _context.Customers.Include("Person");
        }
    }
}
