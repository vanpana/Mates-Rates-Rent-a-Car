using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities
{
    public abstract class Attribute
    {
        protected String value;

        public Attribute() { }

        public Attribute(String value)
        {
            this.value = value;
        }

        public abstract bool Check(Vehicle vehicle);
    }
}
