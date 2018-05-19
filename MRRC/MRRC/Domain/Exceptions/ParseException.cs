using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Exceptions
{
    class ParseException : Exception
    {
        public ParseException(String message) : base(message) { }
    }
}
