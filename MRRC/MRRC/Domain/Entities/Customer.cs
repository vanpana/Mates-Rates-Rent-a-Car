using MRRC.Util;
using System;

namespace MRRC.Domain
{
    public enum CustomerTitle { Ms, Mr, Mrs }

    public enum Gender { male, female }
    class Customer
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

        public int Id { get => _id; set => _id = value; }
        public CustomerTitle Title { get => _title; set => _title = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
        public string DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
    }
}
