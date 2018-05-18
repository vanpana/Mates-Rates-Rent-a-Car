using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities.Attributes
{
    class GPSAttribute : Attribute
    {
        public GPSAttribute()
        {
        }

        public override bool Check(Vehicle vehicle)
        {
            return vehicle.GPS;
        }
    }
}
