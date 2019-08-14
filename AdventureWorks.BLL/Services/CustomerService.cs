using AdventureWorks.BLL.DTOs;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL;
using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.BLL
{
    public class CustomerService:ICustomerService

    {
        private readonly ICustomerRepository _context;

        public CustomerService(ICustomerRepository context)
        {
            _context = context;
        }

  
        public PersonDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CustomerDTO> GetAll()
        {
            var allCustomers = _context.GetAll().Select(x=> new CustomerDTO
                {
                    FirstName=x.Person.FirstName,
                    LastName=x.Person.LastName,
                    AccountNumber=x.AccountNumber,
                    SumOfTotalDue=0

                    
                });

            return allCustomers;
        }

       

        CustomerDTO ICustomerService.GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
