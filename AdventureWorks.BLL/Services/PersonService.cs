using AdventureWorks.BLL.DTOs;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL.Interfaces;
using System.Linq;

namespace AdventureWorks.BLL.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _context;
        public PersonService(IPersonRepository context)
        {
            _context = context;
        }

        public IQueryable<PersonDTO> GetAll()
        {
            var allPersons = _context.GetAll().Select(x => new PersonDTO
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                AccountNumber = ""
            });
            return allPersons;
        }

        public PersonDTO GetByID(int id)
        {
            var person = _context.GetByID(id);
            return new PersonDTO
            {
                FirstName = person.FirstName
                ,
                LastName = person.LastName
            };
        }


    }
}
