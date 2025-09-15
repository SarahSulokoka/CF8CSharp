using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Exceptions
{
    internal class InvalidSsnException : Exception
    {
        public InvalidSsnException() : base("SSN must be exactly 9 digits.")
        {
        }
        public InvalidSsnException(string message) : base(message)
        {
        }
        public InvalidSsnException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
