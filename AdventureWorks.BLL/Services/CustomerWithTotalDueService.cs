﻿using AdventureWorks.BLL.DTOs;
using AdventureWorks.BLL.Services.interfaces;
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
        private readonly ISalesOrderHeaderRepository _salesOrderHeaderRepository;

        public CustomerWithTotalDueService(ICustomerRepository customerRepository,ISalesOrderHeaderRepository salesOrderHeaderRepository)
        {
            _customerRepository = customerRepository;
            _salesOrderHeaderRepository = salesOrderHeaderRepository;
        }
        public IEnumerable<CustomerWithTotalDueDTO> GetAll()
        {
            var allCustomersWithTotalDue = _customerRepository.GetAll()
                                        .Select(x => new CustomerWithTotalDueDTO
                                        {
                                            FirstName = x.Person.FirstName,
                                            LastName = x.Person.LastName,
                                            AccountNumber = x.AccountNumber,
                                            SumOfTotalDue = CalculateTotalDue(x.CustomerID)
                                        });
                                       
            return allCustomersWithTotalDue.AsEnumerable();

        }

        public CustomerWithTotalDueDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }


        private decimal CalculateTotalDue(int id)
        {
            return _salesOrderHeaderRepository.TotalDueByCustomerID(id);
        }

    }
}