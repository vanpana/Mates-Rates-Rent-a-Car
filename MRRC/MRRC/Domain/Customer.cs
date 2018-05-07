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
            this._id = id;
            this._title = Various.ParseEnum<CustomerTitle>(customerTitle);
            this._firstName = firstName;
            this._lastName = lastName;
            this._gender = Various.ParseEnum<Gender>(gender);
            this._dateOfBirth = dateOfBirth;
        }

        public int Id
        {
            get { return Id; }
        }

        public String Title
        {
            get { return _title.ToString();  }
        }
        
        public String FirstName
        {
            get { return _firstName; }
        }

        public String LastName
        {
            get { return _lastName; }
        }

        public String Gender
        {
            get { return _gender.ToString(); }
        }

        public String DOB
        {
            get { return _dateOfBirth; }
        }
        
    }
}
