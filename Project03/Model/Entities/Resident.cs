using System;

namespace Project03.Model.Entities
{
    class Resident
    {
        private int _phoneNumber;
        private int _residenceNumber;
        public Resident(int phoneNumber, int residenceNumber)
        {
            _phoneNumber = phoneNumber;
            _residenceNumber = residenceNumber;
        }
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public int ResidenceNumber
        {
            get{ return _residenceNumber; }
            set{ _residenceNumber = value; }
        }
    }
}