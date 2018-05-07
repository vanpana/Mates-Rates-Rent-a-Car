using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Exceptions
{
    class RepositoryException : Exception
    {
        /// <exception cref="ValidatorException">If the entity is invalid.</exception>
        public RepositoryException(String message) : base(message) { }
    }
}
