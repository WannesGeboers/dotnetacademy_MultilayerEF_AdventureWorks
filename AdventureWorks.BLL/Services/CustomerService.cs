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

        //public List<CustomerDTO> GetAll()
        //{
        //    //var allCustomers = _context.GetAll();
        //    //foreach (var item in allCustomers)
        //    //{

        //    //}
        //}





    }
}
