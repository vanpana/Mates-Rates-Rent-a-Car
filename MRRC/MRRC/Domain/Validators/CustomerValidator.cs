using MRRC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Validators
{
    class CustomerValidator : IValidator<Customer>
    {
        public CustomerValidator() { }
        public void Validate(Customer customer)
        {
            // Check if the registration is not empty
            if (customer.Id < 0)
                throw new ValidatorException("Customer ID must be a valid positive integer!");

            // TODO more validations
        }
    }
}
