using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.CustomExceptions
{
    public class ExceptionsInternas : Exception
    {
        public ExceptionsInternas(string message) : base(message)
        {
        }

        public ExceptionsInternas(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
