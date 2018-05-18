using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities.Logicals
{
    class LogicalAttribute : Logical
    {
        Attribute attribute;

        public LogicalAttribute(Attribute attribute)
        {
            this.attribute = attribute;
        }

        public List<Vehicle> Filter(List<Vehicle> vehicles)
        {
            // Init a new list
            List<Vehicle> filtered = new List<Vehicle>();

            foreach (Vehicle vehicle in vehicles)
            {
                // If the vehicle respects attribute, add it to the list
                if (attribute.Check(vehicle)) filtered.Add(vehicle);
            }

            // Return filtered vehicles
            return filtered;
        }
    }
}
