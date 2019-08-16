using AdventureWorks.BLL.DTOs;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL;
using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.BLL
{
    public class CustomerService : ICustomerService

    {
        private readonly ICustomerRepository _context;

        public CustomerService(ICustomerRepository context)
        {
            _context = context;
        }


        public CustomerDTO GetByID(int id)
        {
            var customer = _context.GetByID(id);
            var dto = new CustomerDTO
            {
                AccountNumber = customer.AccountNumber,
                FirstName = customer.Person.FirstName,
                LastName = customer.Person.LastName
            };
            return dto;
        }

        public CustomerWithTotalDueDTO GetCustomerWithTotalDue(int id)
        {
            Customer c = _context.GetByID(id);
            var dto = new CustomerWithTotalDueDTO
            {
                AccountNumber = c.AccountNumber,
                FirstName = c.Person.FirstName,
                LastName = c.Person.LastName,
                SumOfTotalDue = c.SalesOrderHeaders.Count != 0 ? (decimal)c.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
            };
            return dto;
        }

        public IEnumerable<CustomerWithTotalDueDTO> GetAllCustomersWithTotalDue()
        {
            var allCustomersWithTotalDue = _context.GetAll()
                 .Select(x => new CustomerWithTotalDueDTO
                 {
                     FirstName = x.Person != null ? x.Person.FirstName : "",
                     LastName = x.Person != null ? x.Person.LastName : "",
                     AccountNumber = x.AccountNumber,
                     SumOfTotalDue = x.SalesOrderHeaders.Count != 0 ? (decimal)x.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
                 }).ToList();

            return allCustomersWithTotalDue;
        }

        public IEnumerable<CustomerWithTotalDueDTO> GetAllCustomersAverage(char c)
        {
            var data = _context.GetAll().AsEnumerable();
            var average = data.Sum(x => x.SalesOrderHeaders.Sum(y => y.TotalDue)) / data.Sum(x => x.SalesOrderHeaders.Count);

            data = data.Where(x => x.Person != null);

            if (c.Equals('<'))
            {
                data = data.Where(x => x.SalesOrderHeaders.Sum(y => y.TotalDue) < average);
            }
            if (c.Equals('>'))
            {
                data = data.Where(x => x.SalesOrderHeaders.Sum(y => y.TotalDue) > average);
            }

            var v = data.Select(x => new CustomerWithTotalDueDTO
            {
                FirstName = x.Person != null ? x.Person.FirstName : "",
                LastName = x.Person != null ? x.Person.LastName : "",
                AccountNumber = x.AccountNumber,
                SumOfTotalDue = x.SalesOrderHeaders.Count != 0 ? (decimal)x.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
            })
                .OrderBy(x => x.SumOfTotalDue)
                .ToList();

            return v;
        }


        public IEnumerable<CustomerWithTotalDueDTO> GetByTotalDue(char c,decimal number)
        {
            var data = _context.GetAll().AsEnumerable();          

            data = data.Where(x => x.Person != null);

            if (c.Equals('<'))
            {
                data = data.Where(x => x.SalesOrderHeaders.Sum(y => y.TotalDue) < number);
            }
            if (c.Equals('>'))
            {
                data = data.Where(x => x.SalesOrderHeaders.Sum(y => y.TotalDue) > number);
            }
            if (c.Equals('='))
            {
                data = data.Where(x => x.SalesOrderHeaders.Sum(y => y.TotalDue) == number);
            }

            var resultDTO = data.Select(x => new CustomerWithTotalDueDTO
            {
                FirstName = x.Person != null ? x.Person.FirstName : "",
                LastName = x.Person != null ? x.Person.LastName : "",
                AccountNumber = x.AccountNumber,
                SumOfTotalDue = x.SalesOrderHeaders.Count != 0 ? (decimal)x.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
            })
                .OrderBy(x => x.SumOfTotalDue)
                .ToList();

            return resultDTO;
        }

    }
}