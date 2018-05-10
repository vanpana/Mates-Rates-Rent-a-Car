using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Validators
{
    public abstract class IValidator<T>
    {
        public abstract void Validate(T entity);

        protected Boolean checkStringValidity(String str)
        {
            return str != null && !str.Equals("");
        }
    }
}
