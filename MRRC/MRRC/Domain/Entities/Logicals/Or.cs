using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities.Logicals
{
    class Or : Logical
    {
        Attribute attribute1, attribute2;

        public Or(Attribute attribute1, Attribute attribute2)
        {
            this.attribute1 = attribute1;
            this.attribute2 = attribute2;
        }

        public List<Vehicle> Filter(List<Vehicle> vehicles)
        {
            // Init a new list
            List<Vehicle> filtered = new List<Vehicle>();

            foreach (Vehicle vehicle in vehicles)
            {
                // If the vehicle respects one of the two attributes, add it to the list
                if (attribute1.Check(vehicle) || attribute2.Check(vehicle)) filtered.Add(vehicle);
            }

            // Return filtered vehicles
            return filtered;
        }
    }
}
