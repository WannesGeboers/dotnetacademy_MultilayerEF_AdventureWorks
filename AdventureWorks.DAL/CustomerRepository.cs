using AdventureWorks.BLL.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL
{
    public class CustomerRepository
    {
        private AdventureWorks2017Entities _context {get;set;}


        public CustomerRepository(AdventureWorks2017Entities context)
        {
            _context = context;
        }


        public List<Person> GetAll()
        {
            return _context.People.ToList();

            //PersonDTO res = new PersonDTO
            //{
            //    FirstName = person.FirstName,
            //    LastName = person.LastName
            //};           

        }

    }
}
