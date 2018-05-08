using MRRC.Domain.Entities;
using MRRC.Domain.Validators;
using MRRC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Repository
{
    class RentalRepository : ARepository<Rental, Tuple<String, int>>
    {
        public RentalRepository(IValidator<Rental> validator) : base(validator) { }

        /*
         * Load the CSV data from rental file into the repository.
         * */
        protected override void LoadFromFile()
        {
            // Get all the lines from the CSV file
            List<String[]> splitLines = FileUtil.ReadCSVFromFile(FileUtil.getRentalsFile());

            // If there are any lines in the list, then process them
            if (splitLines.Count > 0)
            {
                // Set the header and get rid of the header strings
                _header = splitLines[0];
                splitLines.RemoveAt(0);

                // Go through each other line and add the vehicles to the list
                foreach (String[] line in splitLines) { Add(new Rental(line)); }
            }
        }

        /*
         * Get a rental by registration and client fields.
         * */
        public override Rental GetItem(Tuple<String, int> registrationAndClient)
        {
            // Iterate through all rentals
            foreach (Rental rental in _items)
            {
                // If the rental with the specified parameters is found, return the object
                if (rental.RegistrationNumber.Equals(registrationAndClient.Item1) && 
                    rental.ClientID == registrationAndClient.Item2) return rental;
            }

            // Return null if no rental with specified registration number and client ID has been found
            return null;
        }
    }
}
