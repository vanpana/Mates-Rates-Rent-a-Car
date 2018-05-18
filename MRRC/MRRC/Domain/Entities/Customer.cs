using MRRC.Util;
using System;

namespace MRRC.Domain
{
    public enum CustomerTitle { Ms, Mr, Mrs }

    public enum Gender { male, female }
    public class Customer : IEquatable<Customer>
    {
        private int _id;
        private CustomerTitle _title;
        private String _firstName;
        private String _lastName;
        private Gender _gender;
        private String _dateOfBirth;

        public Customer(int id, String customerTitle, String firstName, String lastName, String gender, String dateOfBirth)
        {
            this.Id = id;
            this.Title = Various.ParseEnum<CustomerTitle>(customerTitle);
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = Various.ParseEnum<Gender>(gender);
            this.DateOfBirth = dateOfBirth;
        }

        public Customer(String[] parameters)
            : this(int.Parse(parameters[0]), parameters[1], parameters[2], parameters[3], parameters[4], parameters[5]) {}

        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get => _id; set => _id = value; }
        public CustomerTitle Title { get => _title; set => _title = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
        public string DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }

        public bool Equals(Customer other)
        {
            return this.Id == other.Id;
        }

        public String CSV { get => $"{_id},{_title.ToString()},{_firstName},{_lastName},{_gender.ToString()},{_dateOfBirth}"; }
    }
}
