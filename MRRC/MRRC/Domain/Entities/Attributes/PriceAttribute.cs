using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities.Attributes
{
    class PriceAttribute : Attribute
    {
        int floor, ceil;
        public PriceAttribute(int floor, int ceil) : base()
        {
            this.floor = floor;
            this.ceil = ceil;
        }

        public override bool Check(Vehicle vehicle)
        {
            return vehicle.DailyRate >= floor && vehicle.DailyRate <= ceil;
        }
    }
}
