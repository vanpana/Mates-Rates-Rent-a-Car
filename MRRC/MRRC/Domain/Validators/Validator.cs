using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Validators
{
    interface IValidator<T>
    {
        bool Validate(T entity);
    }
}
