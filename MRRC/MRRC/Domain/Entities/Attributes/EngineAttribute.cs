using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities.Attributes
{
    class EngineAttribute : Attribute
    {
        public EngineAttribute(String value) : base(value) { }

        public override bool Check(Vehicle vehicle)
        {
            return vehicle.Fuel.ToString().Equals(value);
        }
    }
}
