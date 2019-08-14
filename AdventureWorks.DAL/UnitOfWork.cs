using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL
{
    public class UnitOfWork : IDisposable
    {
        private AdventureWorks2017Entities _context;
        private GenericRepository<Customer> _customerRepository;
        private GenericRepository<Person> _personRepository;

        public GenericRepository<Customer> CustomerRepository
        {
            get
            {
                return this._customerRepository ?? new GenericRepository<Customer>(_context);
            }
        }


        public GenericRepository<Person> PersonRepository
        {
            get
            {
                return this._personRepository ?? new GenericRepository<Person>(_context);
            }
        }

        public UnitOfWork(AdventureWorks2017Entities context)
        {
            _context = context;
        }


        public void Save()
        {
            _context.SaveChanges();
        }


        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
