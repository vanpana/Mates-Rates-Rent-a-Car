using MRRC.Domain;
using MRRC.Domain.Entities;
using MRRC.Domain.Entities.Attributes;
using MRRC.Domain.Entities.Logicals;
using MRRC.Domain.Exceptions;
using MRRC.Repository;
using MRRC.Util;
using System;
using System.Collections.Generic;

namespace MRRC.Controller
{
    public class ControllerImpl
    {
        private ARepository<Vehicle, String> _vehicleRepository;
        private ARepository<Customer, int> _customerRepository;
        private ARepository<Rental, Tuple<String, int>> _rentalRepository;

        /*
         * Inject repositories into control
         * */
        public ControllerImpl(ARepository<Vehicle, String> vehicleRepository,
            ARepository<Customer, int> customerRepository, ARepository<Rental, Tuple<String, int>> rentalRepository)
        {
            this._vehicleRepository = vehicleRepository;
            this._customerRepository = customerRepository;
            this._rentalRepository = rentalRepository;
        }

        /** FLEET METHODS**/

        /*
         * Adds a vehicle using all the fields necessary
         * */
        public void AddVehicle(String registration, String make, String model, String year, String vehicleClass, int seatNo,
            String transmission, String fuel, bool gps, bool sunroof, String color, int dailyRate)
        {
            try {
                _vehicleRepository.Add(new Vehicle(registration, make, model, year, vehicleClass, seatNo, transmission, fuel, gps.ToString(), sunroof.ToString(), color, dailyRate));
            } catch (RepositoryException repositoryException)
            {
                throw new ControllerException(repositoryException.Message);
            }
        }

        /*
        * Updates a vehicle by registration, if existent, using all the fields necessary
        * */
        public void UpdateVehicle(String registration, String make, String model, String year, String vehicleClass, int seatNo,
            String transmission, String fuel, bool gps, bool sunroof, String color, int dailyRate)
        {
            _vehicleRepository.Update(new Vehicle(registration, make, model, year, vehicleClass, seatNo, transmission, fuel, gps.ToString(), sunroof.ToString(), color, dailyRate));
        }

        /*
        * Deletes a vehicle by registration, if existent. If not, throws Controller Exception.
        * */
        public void DeleteVehicle(String registration)
        {
            try
            {
                // Check if vehicle isn't currently being rented
                if (GetRental(registration) != null) throw new ControllerException("Vehicle is currently being rented!");

                // Build a vehicle only by registration because that's needed for comparison
                _vehicleRepository.Delete(new Vehicle(registration));
            }
            catch (RepositoryException repositoryException)
            {
                throw new ControllerException(repositoryException.Message);
            }
        }

        /*
         * Searches for a vehicle with specified registration number
         * */
        public Vehicle GetVehicle(String registration)
        {
            return _vehicleRepository.GetItem(registration);
        }

        /*
         * Get vehicle header as a CSV string. If there is no header, return an empty string.
         * */
        public String VehicleHeader { get => _vehicleRepository.Header.Length > 0 ? String.Join(",", _vehicleRepository.Header) : ""; }

        /*
         * Get the list of the vehicles in the repository.
         * */
        public List<Vehicle> Vehicles { get => _vehicleRepository.Items; }

        /*
         * Get the list of the vehicles in the repository which are available for renting.
         * */
        public List<Vehicle> AvailableVehicles
        {
            get
                {
                List<Vehicle> vehicles = new List<Vehicle>();

                foreach(Vehicle vehicle in Vehicles)
                {
                    if (GetRental(vehicle.Registration) == null) vehicles.Add(vehicle);
                }

                return vehicles;
            }
        }
        /*
         * Get the list of all vehicles as CSV lines.
         * */
        public String VehicleCSV {
            get {
                String data = VehicleHeader + "\r\n";
                foreach (Vehicle vehicle in Vehicles) { data = data + vehicle.CSV + "\r\n"; }
                return data;
            }
        }

        /** CUSTOMER METHODS**/

        /*
         * Adds a customer using all the fields necessary
         * */
        public void AddCustomer(int id, String customerTitle, String firstName, String lastName, String gender, String dateOfBirth)
        {
            try
            {
                _customerRepository.Add(new Customer(id, customerTitle, firstName, lastName, gender, dateOfBirth));
            }
            catch (RepositoryException repositoryException)
            {
                throw new ControllerException(repositoryException.Message);
            }
        }

        /*
        * Updates a customer by ID, if existent, using all the fields necessary
        * */
        public void UpdateCustomer(int id, String customerTitle, String firstName, String lastName, String gender, String dateOfBirth)
        {
            _customerRepository.Update(new Customer(id, customerTitle, firstName, lastName, gender, dateOfBirth));
        }

        /*
        * Deletes a customer by ID, if existent. If not, throws Controller Exception.
        * */
        public void DeleteCustomer(int id)
        {
            try
            {
                // Check if client isn't already renting
                if (GetRental(id) != null) throw new ControllerException("Client is currently renting!");

                // Build a customer only by id because that's needed for comparison
                _customerRepository.Delete(new Customer(id));
            }
            catch (RepositoryException repositoryException)
            {
                throw new ControllerException(repositoryException.Message);
            }
        }

        /*
         * Searches for a customer with specified ID
         * */
        public Customer GetCustomer(int id)
        {
            return _customerRepository.GetItem(id);
        }

        /*
         * Get the customer header as a CSV string. If there is no header, return an empty string.
         * */
        public String CustomerHeader { get => _customerRepository.Header.Length > 0 ? String.Join(",", _customerRepository.Header) : ""; }

        /*
         * Get all the customers in the repository.
         * */
        public List<Customer> Customers { get => _customerRepository.Items; }

        /*
         * Get all the customers as CSV lines.
         * */
        public String CustomersCSV
        {
            get
            {
                String data = CustomerHeader + "\r\n";
                foreach (Customer customer in Customers) { data = data + customer.CSV + "\r\n"; }
                return data;
            }
        }
        /** RENTAL METHODS**/
        /*
        * Adds a rental using all only registration and client id necessary
        * */
        public void AddRental(String registrationNumber, int customerID)
        {
            try
            {
                // Check if vehicle exists
                Vehicle vehicle = GetVehicle(registrationNumber);
                if (vehicle == null) throw new ControllerException($"Vehicle with registration {registrationNumber} does not exist.");

                // Check if client exists
                if (GetCustomer(customerID) == null) throw new ControllerException($"Customer with id {customerID} does not exist.");

                // Check if vehicle not rented already or customer isn't already renting
                foreach (Rental rental in Rentals)
                {
                    if (rental.RegistrationNumber.Equals(registrationNumber)) throw new ControllerException("Vehicle is already rented!");
                    if (rental.ClientID == customerID) throw new ControllerException("Customer is already renting!");
                }

                // Search for daily rate
                _rentalRepository.Add(new Rental(registrationNumber, customerID, vehicle.DailyRate));
            }
            catch (RepositoryException repositoryException)
            {
                throw new ControllerException(repositoryException.Message);
            }
        }

        /*
         * Adds a rental using all the fields necessary
         * */
        public void AddRental(String registrationNumber, int clientID, int dailyRate)
        {
            try
            {
                _rentalRepository.Add(new Rental(registrationNumber, clientID, dailyRate));
            }
            catch (RepositoryException repositoryException)
            {
                throw new ControllerException(repositoryException.Message);
            }
        }

        /*
        * Updates a rental, if existent, using all the fields necessary
        * */
        public void UpdateRental(String registrationNumber, int clientID, int dailyRate)
        {
            _rentalRepository.Update(new Rental(registrationNumber, clientID, dailyRate));
        }

        /*
        * Deletes a rental by registration and clientID, if existent. If not, throws Controller Exception.
        * */
        public void DeleteRental(Tuple<String, int> registrationAndClient)
        {
            try
            {
                // Build a Rental only by registration number and client id because that's needed for comparison
                _rentalRepository.Delete(new Rental(registrationAndClient));
            }
            catch (RepositoryException repositoryException)
            {
                throw new ControllerException(repositoryException.Message);
            }
        }

        /*
         * Searches for a Rental with specified registrationNumber and clientID
         * */
        public Rental GetRental(Tuple<String, int> registrationAndClient)
        {
            return _rentalRepository.GetItem(registrationAndClient);
        }


        /*
         * Searches for a Rental by clientID
         * */
        public Rental GetRental(int clientID)
        {
            foreach (Rental rental in Rentals) if (rental.ClientID == clientID) return rental;
            return null;
        }

        /*
         * Searches for a Rental by registration number
         * */
        public Rental GetRental(String registration)
        {
            foreach (Rental rental in Rentals) if (rental.RegistrationNumber.Equals(registration)) return rental;
            return null;
        }

        /*
         * Get the rental header as CSV string. If there is no header, return an empty string.
         * */
        public String RentalHeader { get => _rentalRepository.Header.Length > 0 ? String.Join(",", _rentalRepository.Header) : ""; }

        /*
         * Get all the rentals saved in the repository.
         * */
        public List<Rental> Rentals { get => _rentalRepository.Items; }

        /*
         * Get all the rentals as CSV lines.
         * */
        public String RentalCSV
        {
            get
            {
                String data = RentalHeader + "\r\n";
                foreach (Rental rental in Rentals) { data = data + rental.CSV + "\r\n"; }
                return data;
            }
        }

        // Searching
        /*
         * Get Logical expression from rate query. (format should be min-max)
         * */
        public Logical GetLogicalFromRate(String rateQuery)
        {
            // Check if format is min-max
            String rate = rateQuery.Replace(" ", "");

            // Split the rate string
            String[] parts = rate.Split('-');

            // Check if the format is correct
            if (parts.Length != 2) throw new Exception("Invalid price format!");

            // Get the min and max rates
            int min = int.Parse(parts[0]);
            int max = int.Parse(parts[1]);

            // Build the logical attribute
            return new LogicalAttribute(new PriceAttribute(min, max));
        }

        /*
         * Get logical expression from search query.
         * */
        public Logical GetLogicalFromQuery(String query)
        {
            if (query.Split(' ').Length == 1) return LogicalUtil.GetLogicalAttribute(query);
            return LogicalUtil.GetLogical(query);
        } 
    }
}
