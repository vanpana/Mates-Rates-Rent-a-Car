using System;
using System.Collections.Generic;

namespace MRRC.Domain.Entities.Logicals
{
    public interface Logical
    {
        List<Vehicle> Filter(List<Vehicle> vehicles);
    }
}
