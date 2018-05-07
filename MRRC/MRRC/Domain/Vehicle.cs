using MRRC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain
{
    public enum VehicleClass { economy, family, luxury, commercial }

    public enum Transmission { automatic, manual }

    public enum Fuel { petrol, diesel }
    class Vehicle
    {
        string registration, make, model, year;
        VehicleClass vehicleClass;
        int seatNo;
        Transmission transmission;
        Fuel fuel;
        String color;
        int dailyRate;
        
        public Vehicle(String registration, String make, String model, String year, String vehicleClass, int seatNo,
            String transmission, String fuel, String color, int dailyRate)
        {
            this.registration = registration;
            this.make = make;
            this.model = model;
            this.year = year;
            this.vehicleClass = Various.ParseEnum<VehicleClass>(vehicleClass);
            this.seatNo = seatNo;
            this.transmission = Various.ParseEnum<Transmission>(transmission);
            this.fuel = Various.ParseEnum<Fuel>(fuel);
            this.color = color;
            this.dailyRate = dailyRate;
        }
    }
}
