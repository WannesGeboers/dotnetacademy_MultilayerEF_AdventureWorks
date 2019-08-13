using AdventureWorks.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.BLL
{
    public class CustomerService
    {
        private CustomerRepository _context { get; set; }


        public CustomerService(CustomerRepository context)
        {
            _context = context;
        }

        public List<CustomerDTO> GetAll()
        {
            var x = _context.GetAll();
                       
            
        }

        //public List<CustomerDTO> GetAllCustomers()
        //{
        //    var x = _context.GetAll();
        //    x.Select(x=> new CustomerDTO
        //    {AccountNumber
        //        x.)
        //}
    }
}
