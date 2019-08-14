using AdventureWorks.BLL.DTOs;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.BLL
{
    public class CustomerService:IService

    {
        private readonly CustomerRepository _context;

        public CustomerService(CustomerRepository context)
        {
            _context = context;
        }

  
        public PersonDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<CustomerDTO> GetAll()
        {
            var allCustomers = _context.GetAll()
                .Select(x=> new CustomerDTO
                {

                })
                ;

            return allCustomers;
        }

        IQueryable<PersonDTO> IService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
