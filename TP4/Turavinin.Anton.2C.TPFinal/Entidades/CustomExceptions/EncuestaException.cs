using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.CustomExceptions
{
    public class EncuestaException : Exception
    {
        public EncuestaException(string message) : base(message)
        {
        }

        public EncuestaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
