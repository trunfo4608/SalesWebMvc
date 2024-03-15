using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exception
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message)
            : base(message) { }
    }
}
