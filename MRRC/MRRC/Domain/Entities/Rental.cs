using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Domain.Entities
{
    public class Rental : IEquatable<Rental>
    {
        String _registrationNumber;
        int _clientID;
        int _dailyRate;

        public Rental(String registrationNumber, int clientID, int dailyRate)
        {
            RegistrationNumber = registrationNumber;
            ClientID = clientID;
            DailyRate = dailyRate;
        }

        public Rental(string[] line) : this(line[0], int.Parse(line[1]), int.Parse(line[2])) { }

        public Rental(Tuple<String, int> registrationAndCustomer)
        {
            RegistrationNumber = registrationAndCustomer.Item1;
            ClientID = registrationAndCustomer.Item2;
        }

        public string RegistrationNumber { get => _registrationNumber; set => _registrationNumber = value; }
        public int ClientID { get => _clientID; set => _clientID = value; }
        public int DailyRate { get => _dailyRate; set => _dailyRate = value; }

        public bool Equals(Rental other)
        {
            return this._clientID == other.ClientID && this._registrationNumber.Equals(other.RegistrationNumber)
                && this._dailyRate == other.DailyRate;
        }

        public String CSV { get => $"{_registrationNumber},{_clientID},{_dailyRate}";  }
    }
}
