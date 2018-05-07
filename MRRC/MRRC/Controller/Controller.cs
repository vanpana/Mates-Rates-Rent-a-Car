using MRRC.Domain;
using MRRC.Domain.Exceptions;
using MRRC.Repository;
using System;
using System.Collections.Generic;

namespace MRRC.Controller
{
    class Controller
    {
        private ARepository<Vehicle> _vehicleRepository;
        private ARepository<Customer> _customerRepository;

        public Controller(ARepository<Vehicle> vehicleRepository, ARepository<Customer> customerRepository)
        {
            this._vehicleRepository = vehicleRepository;
            this._customerRepository = customerRepository;
        }

        /*
         * Adds a vehicle using all the fields necessary
         * */
        public void AddVehicle(String registration, String make, String model, String year, String vehicleClass, int seatNo,
            String transmission, String fuel, String color, int dailyRate)
        {
            try {
                _vehicleRepository.Add(new Vehicle(registration, make, model, year, vehicleClass, seatNo, transmission, fuel, color, dailyRate));
            } catch (RepositoryException repositoryException)
            {
                throw new ControllerException(repositoryException.Message);
            }
        }
        
        // TODO: Update vehicle
        // TODO: Delete vehicle

        public Vehicle GetVehicle(String registration)
        {
            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.Registration.Equals(registration)) return vehicle;
            }
            return null;
        }

        public List<Vehicle> Vehicles { get => _vehicleRepository.Items; }
    }
}
