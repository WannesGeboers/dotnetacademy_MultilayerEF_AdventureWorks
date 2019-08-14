using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL
{
    
    public class PersonRepository:IPersonRepository
    {
        private readonly AWContext _context;
        public PersonRepository(AWContext context)
        {
            _context = context;
        }


        public IQueryable<Person> GetAll()
        {
            return _context.People.Include("Customers");
        }

        public Person GetByID(int id)
        {
            return _context.People.SingleOrDefault(x => x.BusinessEntityID == id);
        }
    }
}
