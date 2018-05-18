using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Exceptions
{
    class ControllerException : Exception
    {
        /// <exception cref="ValidatorException">If the entity is invalid.</exception>
        public ControllerException(String message) : base(message) { }
    }
}
