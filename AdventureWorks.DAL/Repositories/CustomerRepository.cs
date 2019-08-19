using AdventureWorks.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private AWContext _context { get; }


        public CustomerRepository(AWContext context)
        {
            //nullcheck
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Customer GetByID(int id)
        {
            return
                _context.Customers
                .Include("Person")
                .Include("SalesOrderHeaders")
                .Where(x => x.CustomerID == id)
                .SingleOrDefault();
        }

        public IQueryable<Customer> GetAll()
        {
            var customers =
                _context.Customers
                .Include("Person")
                .Include("SalesOrderHeaders");
            return customers;
        }


        public IEnumerable<Customer> FilterByFirstName(string name)
        {
                var customers =
                    _context.Customers
                    .Include("Person")
                    .Include("SalesOrderHeaders")
                    .Where(x=>x.Person.FirstName.Contains(name))
                    .ToList();
                return customers;
        }

        public IEnumerable<Customer> FilterByLastName(string name)
        {
            var customers =
                _context.Customers
                .Include("Person")
                .Include("SalesOrderHeaders")
                .Where(x => x.Person.LastName.Contains(name))
                .ToList();
            return customers;
        }

        public IEnumerable<Customer> FilterByAccountNumber(string name)
        {
            var customers =
                _context.Customers
                .Include("Person")
                .Include("SalesOrderHeaders")
                .Where(x => x.AccountNumber.Contains(name))
                .ToList();
            return customers;
        }

        public IEnumerable<Customer> FilterByStringAndAttribute(string search,string attribute)
        {
            var customers =
                 _context.Customers
                 .Include("Person")
                 .Include("SalesOrderHeaders").AsEnumerable();

            customers = customers
                .Where(x => x.Person != null);
                

            switch (attribute)
            {
                case "FirstName":
                    customers = customers.Where(x => x.Person.FirstName.Contains(search))
                                        .OrderBy(x=>x.Person.FirstName);
                    break;
                case "LastName":
                    customers = customers.Where(x => x.Person.LastName.Contains(search))
                             .OrderBy(x => x.Person.LastName);
                    break;
                case "AccountNumber":
                    customers = customers.Where(x => x.AccountNumber.Contains(search))
                                 .OrderBy(x => x.AccountNumber);
                    break;
                default:
                    break;
            };                     
                 
            return customers;
        }
    }
}
