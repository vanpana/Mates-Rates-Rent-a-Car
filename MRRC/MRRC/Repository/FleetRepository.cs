using MRRC.Domain;
using MRRC.Domain.Validators;
using MRRC.Util;
using System;
using System.Collections.Generic;

namespace MRRC.Repository
{
    class FleetRepository : ARepository<Vehicle, String>
    {
        public FleetRepository(IValidator<Vehicle> validator) : base(validator) {}

        /*
         * Load the CSV data from fleet file into the repository.
         * */
        protected override void LoadFromFile()
        {
            // Get all the lines from the CSV file
            List<String[]> splitLines = FileUtil.ReadCSVFromFile(FileUtil.getFleetsFile());

            // If there are any lines in the list, then process them
            if (splitLines.Count > 0)
            {
                // Set the header and get rid of the header strings
                _header = splitLines[0];
                splitLines.RemoveAt(0);

                // Go through each other line and add the vehicles to the list
                foreach (String[] line in splitLines) { Add(new Vehicle(line)); }
            }
        }

        /*
         * Get a vehicle by registration number.
         * */
        public override Vehicle GetItem(string registration)
        {
            // Iterate through all vehicles
            foreach (Vehicle vehicle in _items)
            {
                // If the vehicles with the specified registration number is found, return the object
                if (vehicle.Registration.Equals(registration)) return vehicle;
            }

            // Return null if no vehicle with specified registration number has been found
            return null;
        }
    }
}
