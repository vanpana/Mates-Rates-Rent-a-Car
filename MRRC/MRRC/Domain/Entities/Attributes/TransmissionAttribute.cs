using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities.Attributes
{
    class TransmissionAttribute : Attribute
    {
        public TransmissionAttribute(String value) : base(value) { }

        public override bool Check(Vehicle vehicle)
        {
            return vehicle.Transmission.ToString().Equals(value);
        }
    }
}
