using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.DAL
{
    public class AVContext:DbContext
    {
        public AVContext() : base("AVContext")
        {

        }
    }
}
