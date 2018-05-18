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
    class CustomerRepository : ARepository<Customer, int>
    {
        public CustomerRepository(IValidator<Customer> validator) : base(validator) { }

        /*
         * Load the CSV data from customers file into the repository.
         * */
        protected override void LoadFromFile()
        {
            // Get all the lines from the CSV file
            List<String[]> splitLines = FileUtil.ReadCSVFromFile(FileUtil.getCustomersFile());

            // If there are any lines in the list, then process them
            if (splitLines.Count > 0)
            {
                // Set the header and get rid of the header strings
                _header = splitLines[0];
                splitLines.RemoveAt(0);

                // Go through each other line and add the vehicles to the list
                foreach (String[] line in splitLines)
                {
                    Add(new Customer(line));
                }
            }
        }

        /*
         * Get a customer by ID
         * */
        public override Customer GetItem(int id)
        {
            // Iterate through all customers
            foreach (Customer customer in _items)
            {
                // If the customer with the specified ID is found, return the object
                if (customer.Id == id) return customer;
            }

            // Return null if no client with specified ID has been found
            return null;
        }
    }
}
