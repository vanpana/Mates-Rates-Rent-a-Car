using MRRC.Domain.Entities;
using MRRC.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Exceptions
{
    class RentalValidator : IValidator<Rental>
    {
        public override void Validate(Rental rental)
        {
            // Check if client ID is valid
            if (rental.ClientID < 0) throw new ValidatorException("Client ID must be a valid positive integer!");

            // Check if rental number is not empty
            if (rental.RegistrationNumber == null || rental.RegistrationNumber.Equals(""))
                throw new ValidatorException("Registration number must not be empty!");

            // Check if daily rate is valid
            if (rental.DailyRate < 0) throw new ValidatorException("Daily rate must be a valid positive integer!");
        }
    }
}
