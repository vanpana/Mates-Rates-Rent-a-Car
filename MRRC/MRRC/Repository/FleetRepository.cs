using MRRC.Domain;
using MRRC.Domain.Validators;
using MRRC.Util;
using System;
using System.Collections.Generic;

namespace MRRC.Repository
{
    class FleetRepository : ARepository<Vehicle>
    {
        public FleetRepository(IValidator<Vehicle> validator) : base(validator) {}

        protected override void LoadFromFile()
        {
            // Get all the lines from the CSV file
            List<String[]> splitLines = FileUtil.ReadCSVFromFile(FileUtil.getFleetsFile());

            // Set the header and get rid of the header strings
            _header = splitLines[0];
            splitLines.RemoveAt(0);

            // Go through each other line and add the vehicles to the list
            foreach (String[] line in splitLines) { Add(new Vehicle(line)); }
        }
    }
}
