using MRRC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MRRC.Domain.Validators
{
    class CustomerValidator : IValidator<Customer>
    {
        // Regular expression to match dates like: dd.mm.yyy or dd/mm/yyyy or dd-mm-yyy.s
        private Regex dateRegex = new Regex(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");
        public CustomerValidator() { }

        public override void Validate(Customer customer)
        {
            // Check if the registration is not empty
            if (customer.Id < 0)
                throw new ValidatorException("Customer ID must be a valid positive integer!");

            // Check if the first name is valid
            if (!checkStringValidity(customer.FirstName)) throw new ValidatorException("First name cannot be empty!");

            // Check if the last name is valid
            if (!checkStringValidity(customer.LastName)) throw new ValidatorException("Last name cannot be empty!");

            // Check if the date is valid
            if (!checkStringValidity(customer.DateOfBirth)) throw new ValidatorException("Date of birth cannot be empty!");

            // Check if date format is valid
            Match match = dateRegex.Match(customer.DateOfBirth);
            if (match == null || match.Value.Equals("")) throw new ValidatorException("Date of birth is in incorrect format!");
        }
    }
}
