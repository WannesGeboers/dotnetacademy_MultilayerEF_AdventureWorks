using AdventureWorks.BLL.DTOs;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL;
using AdventureWorks.DAL.Interfaces;
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
                     FirstName = x.Person != null ? x.Person.FirstName : "unknown",
                     LastName = x.Person != null ? x.Person.LastName : "unknown",
                     AccountNumber = x.AccountNumber,
                     SumOfTotalDue = //CalculateTotalDue(x)
                     x.SalesOrderHeaders.Count != 0 ? (decimal)x.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
                 });

            return allCustomersWithTotalDue.ToList();
        }

        public IEnumerable<CustomerWithTotalDueDTO> GetAllCustomersAverage(char c)
        {
            var data = _context.GetAll().AsEnumerable();
            var average = data.Sum(x => x.SalesOrderHeaders.Sum(y => y.TotalDue)) / data.Sum(x => x.SalesOrderHeaders.Count);

            //data builder

            data = data.Where(x => x.Person != null);

            //button lower
            if (c.Equals('<'))
            {
                data = data.Where(x => x.SalesOrderHeaders.Sum(y => y.TotalDue) < average);
            }
            //button higher
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


        public IEnumerable<CustomerWithTotalDueDTO> FilterByTotalDue(char c, decimal number)
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

        IEnumerable<CustomerWithTotalDueDTO> ICustomerService.FilterByFirstName(string name)
        {
            
            var listCustomersDTO = _context.FilterByFirstName(name)
                  .Select(x => new CustomerWithTotalDueDTO
                  {
                      FirstName = x.Person.FirstName,
                      LastName = x.Person.LastName,
                      AccountNumber = x.AccountNumber,
                      SumOfTotalDue = //CalculateTotalDue(x)
                      x.SalesOrderHeaders.Count != 0 ? (decimal)x.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
                  })
                  .ToList();

            return listCustomersDTO;
        }

        IEnumerable<CustomerWithTotalDueDTO> ICustomerService.FilterByLastName(string name)
        {
            var listCustomersDTO = _context.FilterByLastName(name)
                     .Select(x => new CustomerWithTotalDueDTO
                     {
                         FirstName = x.Person.FirstName,
                         LastName = x.Person.LastName,
                         AccountNumber = x.AccountNumber,
                         SumOfTotalDue = //CalculateTotalDue(x)
                         x.SalesOrderHeaders.Count != 0 ? (decimal)x.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
                     })
                     .ToList();

            return listCustomersDTO;
        }

        IEnumerable<CustomerWithTotalDueDTO> ICustomerService.FilterByAccountNumber(string name)
        {
            var listCustomersDTO = _context.FilterByAccountNumber(name)
                .Where(x => x.AccountNumber.Contains(name))
                .Select(x => new CustomerWithTotalDueDTO
                {
                    FirstName = x.Person.FirstName,
                    LastName = x.Person.LastName,
                    AccountNumber = x.AccountNumber,
                    SumOfTotalDue = //CalculateTotalDue(x)
                    x.SalesOrderHeaders.Count != 0 ? (decimal)x.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
                })
                .ToList();

            return listCustomersDTO;
        }

        //IEnumerable<CustomerWithTotalDueDTO> ICustomerService.FilterBystringAttribute(string name,string attribute)
        //{
        //    var listCustomersDTO = _context

        //              .FilterByLastName(name)
        //             .Select(x => new CustomerWithTotalDueDTO
        //             {
        //                 FirstName = x.Person.FirstName,
        //                 LastName = x.Person.LastName,
        //                 AccountNumber = x.AccountNumber,
        //                 SumOfTotalDue = //CalculateTotalDue(x)
        //                 x.SalesOrderHeaders.Count != 0 ? (decimal)x.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
        //             })
        //             .ToList();

        //    return listCustomersDTO;
        //}


        public decimal CalculateTotalDue(Customer c)
        {
            decimal sum = c.SalesOrderHeaders.Count != 0 ? (decimal)c.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0;
            return sum;
        }

        public IEnumerable<CustomerWithTotalDueDTO> FilterByStringAndAttribute(string search, string attribute)
        {
          var listCustomersDTO = _context.FilterByStringAndAttribute(search,attribute)
            .Select(x => new CustomerWithTotalDueDTO
            {
                FirstName = x.Person.FirstName,
                LastName = x.Person.LastName,
                AccountNumber = x.AccountNumber,
                SumOfTotalDue = //CalculateTotalDue(x)
                x.SalesOrderHeaders.Count != 0 ? (decimal)x.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0
            })
            .ToList();

            return listCustomersDTO;
        }
    }
}