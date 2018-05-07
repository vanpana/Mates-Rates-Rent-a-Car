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
        private String _registration, _make, _model, _year;
        private VehicleClass _vehicleClass;
        private int _seatNo;
        private Transmission _transmission;
        private Fuel _fuel;
        private String _color;
        private int _dailyRate;
        
        public Vehicle(String registration, String make, String model, String year, String vehicleClass, int seatNo,
            String transmission, String fuel, String color, int dailyRate)
        {
            this.Registration = registration;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.VehicleClass = Various.ParseEnum<VehicleClass>(vehicleClass);
            this.SeatNo = seatNo;
            this.Transmission = Various.ParseEnum<Transmission>(transmission);
            this.Fuel = Various.ParseEnum<Fuel>(fuel);
            this.Color = color;
            this.DailyRate = dailyRate;
        }


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
    }
}
