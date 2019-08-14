using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.DAL
{
    public class CustomerRepository
    {
        private AWContext _context {get;set;}


        public CustomerRepository(AWContext context)
        {
            _context = context;
        }


        public List<Person> GetAll()
        {
            return _context.People.ToList();
        }

    }
}
