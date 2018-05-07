using MRRC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Validators
{
    class VehicleValidator : IValidator<Vehicle>
    {
        public VehicleValidator() { }

        public void Validate(Vehicle vehicle)
        {
            // Check if the registration is not empty
            if (vehicle.Registration == null || vehicle.Registration.Equals(""))
                throw new ValidatorException("Registration can't be null or empty!");

            // TODO more validations
        }
    }
}
