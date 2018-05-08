using MRRC.Domain;
using MRRC.Domain.Entities;
using MRRC.Domain.Exceptions;
using MRRC.Repository;
using System;
using System.Collections.Generic;

namespace MRRC.Controller
{
    public class ControllerImpl
    {
        private ARepository<Vehicle, String> _vehicleRepository;
        private ARepository<Customer, int> _customerRepository;
        private ARepository<Rental, Tuple<String, int>> _rentalRepository;

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
            String transmission, String fuel, String gps, String sunroof, String color, int dailyRate)
        {
            try {
                _vehicleRepository.Add(new Vehicle(registration, make, model, year, vehicleClass, seatNo, transmission, fuel, gps, sunroof, color, dailyRate));
            } catch (RepositoryException repositoryException)
            {
                throw new ControllerException(repositoryException.Message);
            }
        }

        /*
        * Updates a vehicle by registration, if existent, using all the fields necessary
        * */
        public void UpdateVehicle(String registration, String make, String model, String year, String vehicleClass, int seatNo,
            String transmission, String fuel, String gps, String sunroof, String color, int dailyRate)
        {
            _vehicleRepository.Update(new Vehicle(registration, make, model, year, vehicleClass, seatNo, transmission, fuel, gps, sunroof, color, dailyRate));
        }

        /*
        * Deletes a vehicle by registration, if existent. If not, throws Controller Exception.
        * */
        public void DeleteVehicle(String registration)
        {
            try
            {
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

        public String[] VehicleHeader { get => _vehicleRepository.Header; }

        public List<Vehicle> Vehicles { get => _vehicleRepository.Items; }

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

        public String[] CustomerHeader { get => _customerRepository.Header; }

        public List<Customer> Customers { get => _customerRepository.Items; }

        /** RENTAL METHODS**/

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

        public String[] RentalHeader { get => _rentalRepository.Header; }

        public List<Rental> Rentals { get => _rentalRepository.Items; }
    }
}
