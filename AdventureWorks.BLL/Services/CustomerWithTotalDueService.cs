using AdventureWorks.BLL.DTOs;
using AdventureWorks.BLL.Services.interfaces;
using AdventureWorks.DAL;
using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.BLL.Services
{

    public class CustomerWithTotalDueService : ICustomerWithTotalDueService
    {
        private readonly ICustomerRepository _customerRepository;      
       

        public CustomerWithTotalDueService(ICustomerRepository customerRepository,ISalesOrderHeaderRepository salesOrderHeaderRepository)
        {
            _customerRepository = customerRepository;                    
        }


        public CustomerWithTotalDueDTO GetByID(int id)
        {
            var customer = _customerRepository.GetByID(id);

            return new CustomerWithTotalDueDTO
            {
                AccountNumber = customer.AccountNumber,
                FirstName = customer.Person.FirstName,
                LastName = customer.Person.LastName,
                SumOfTotalDue = CalculateTotalDue(customer)
            };
        }



        public IQueryable<CustomerWithTotalDueDTO> GetAll()
        {
            var allCustomersWithTotalDue = _customerRepository.GetAll()
                            .Select(x => new CustomerWithTotalDueDTO
                            {
                                FirstName = x.Person.FirstName,
                                LastName = x.Person.LastName,
                                AccountNumber = x.AccountNumber,
                                SumOfTotalDue = CalculateTotalDue(x)
                            });

            return allCustomersWithTotalDue;
        }


        public List<CustomerWithTotalDueDTO> FilterByFirstName(string name)
        {
            var listCustomersDTO = _customerRepository.GetAll()
                            .Where(x => x.Person.FirstName.Contains(name))
                            .Select(x => new CustomerWithTotalDueDTO
                            {
                                FirstName = x.Person.FirstName,
                                LastName = x.Person.LastName,
                                AccountNumber = x.AccountNumber,
                                SumOfTotalDue = CalculateTotalDue(x)
                            })
                            .ToList();
            return listCustomersDTO;
        }

        //public List<CustomerWithTotalDueDTO> FilterByTotalDue(string text)
        //{
        //    if (string.IsNullOrEmpty(text) == true)
        //    {
        //        return GetAll().ToList();
        //    }
        //    else
        //    {                        

        //            char first = text[0];
        //            if (first.Equals('=') || first.Equals('<') || first.Equals('>') == true)
        //            {
        //                var numbTest = text.Replace(first.ToString(), "").Trim();
        //                if (decimal.TryParse(numbTest, out decimal result) == true)
        //                {
        //                    var data = _customerService.GetByTotalDue(first, result);
        //                    DisplayData(data);
        //                }
        //            }
        //        }
        //        else
        //        {
        //        }
        //    }



        private decimal CalculateTotalDue(Customer c)
        {
            decimal sum = c.SalesOrderHeaders.Count != 0 ? (decimal)c.SalesOrderHeaders.Sum(y => y.TotalDue) : (decimal)0;

            return sum;
        }
    }
}
