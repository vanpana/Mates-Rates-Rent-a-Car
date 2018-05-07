using MRRC.Domain;
using MRRC.Domain.Validators;
using MRRC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Repository
{
    class FleetRepository : ARepository<Vehicle>
    {
        FleetRepository(IValidator<Vehicle> validator) : base(validator) {}

        protected override void LoadFromFile()
        {
            // Get all the lines from the CSV file
            List<String[]> splitLines = FileUtil.ReadCSVFromFile(FileUtil.getFleetsFile());

            // Set the header and get rid of the header strings
            _header = splitLines[0];
            splitLines.RemoveAt(0);

            // Go through each other line and add the vehicles to the list
            foreach (String[] line in splitLines)
            {
                Add(new Vehicle(line[0], line[1], line[2], line[3], line[4], int.Parse(line[5]), line[6], line[7], line[8], int.Parse(line[9])));
            }
        }
    }
}
