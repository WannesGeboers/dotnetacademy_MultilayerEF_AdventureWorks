using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.BLL.DTOs
{
    public class SalesOrderHeaderDTO
    {
        public string AccountNumber { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalDue { get; set; }
        public Customer Customer { get; set; }
    }
}
