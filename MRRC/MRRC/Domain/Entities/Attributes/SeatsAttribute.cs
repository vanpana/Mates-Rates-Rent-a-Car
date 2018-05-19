using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities.Attributes
{
    class SeatsAttribute : Attribute
    {
        public SeatsAttribute(string value) : base(value)
        {
        }

        public override bool Check(Vehicle vehicle)
        {
            // Lower case the string
            value = value.ToLower();

            // If the value contains 'seater', trim it to only contain a digit (meaning the seats)
            if (value.Contains("seater")) value = value.Split('-')[0];

            // Verify if the seats number are correct
            return vehicle.SeatNo == int.Parse(value);
        }
    }
}
