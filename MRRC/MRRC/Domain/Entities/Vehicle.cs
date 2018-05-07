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
    public class Vehicle : IEquatable<Vehicle>
    {
        private String _registration, _make, _model, _year;
        private VehicleClass _vehicleClass;
        private int _seatNo;
        private Transmission _transmission;
        private Fuel _fuel;
        private Boolean _gps, _sunroof;
        private String _color;
        private int _dailyRate;

        public Vehicle(String registration, String make, String model, String year, String vehicleClass, int seatNo,
            String transmission, String fuel, String gps, String sunroof, String color, int dailyRate)
        {
            this.Registration = registration;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.VehicleClass = Various.ParseEnum<VehicleClass>(vehicleClass);
            this.SeatNo = seatNo;
            this.Transmission = Various.ParseEnum<Transmission>(transmission);
            this.Fuel = Various.ParseEnum<Fuel>(fuel);
            this.GPS = Various.BoolFromString(gps);
            this.Sunroof = Various.BoolFromString(sunroof);
            this.Color = color;
            this.DailyRate = dailyRate;
        }

        public Vehicle(String[] line)
            : this(line[0], line[1], line[2], line[3], line[4], int.Parse(line[5]), line[6], line[7], line[8], line[9], line[10], int.Parse(line[11])) { }


        public string Registration { get => _registration; set => _registration = value; }
        public VehicleClass VehicleClass { get => _vehicleClass; set => _vehicleClass = value; }
        public int SeatNo { get => _seatNo; set => _seatNo = value; }
        public Transmission Transmission { get => _transmission; set => _transmission = value; }
        public Fuel Fuel { get => _fuel; set => _fuel = value; }
        public string Color { get => _color; set => _color = value; }
        public int DailyRate { get => _dailyRate; set => _dailyRate = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public string Year { get => _year; set => _year = value; }
        public bool GPS { get => _gps; set => _gps = value; }
        public bool Sunroof { get => _sunroof; set => _sunroof = value; }

        // Check if the vehicles are the same by verifying Registration number
        public bool Equals(Vehicle other)
        {
            return this.Registration.Equals(other.Registration);
        }

        public String CSV
        {
            get => $" {_registration}, {_make}, {_model}, {_year}, {_vehicleClass.ToString()}, {_seatNo.ToString()}," +
               $"{_transmission.ToString()}, {_fuel.ToString()}, {_gps.ToString()}, {_sunroof.ToString()}, {_color}, {_dailyRate.ToString()}";
        }
    }
}
