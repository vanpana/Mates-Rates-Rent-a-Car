using MRRC.Domain.Entities.Logicals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities.Logicals
{
    public class AndCompositeLogical : Logical
    {
        Logical logical1;
        Logical logical2;

        public AndCompositeLogical(Logical logical1, Logical logical2)
        {
            this.logical1 = logical1;
            this.logical2 = logical2;
        }

        public List<Vehicle> Filter(List<Vehicle> vehicles)
        {
            return logical1.Filter(vehicles).Intersect(logical2.Filter(vehicles)).ToList();
        }
    }
}
