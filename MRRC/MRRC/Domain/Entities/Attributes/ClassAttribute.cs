using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities.Attributes
{
    class ClassAttribute : Attribute
    {
        public ClassAttribute(String value) : base(value) { }

        public override bool Check(Vehicle vehicle)
        {
            return vehicle.VehicleClass.ToString().Equals(value);
        }
    }
}
