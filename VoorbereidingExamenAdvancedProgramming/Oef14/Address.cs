    using System;
using System.Collections.Generic;
using System.Text;

namespace Oef14
{
    class Address
    {
        private String street;
        private String city;
        private int streetNumber;
        private int postCode;

        public Address(string newStreet, string newCity, int newStreetNumber, int newPostCode)
        {
            street = newStreet;
            city = newCity;
            streetNumber = newStreetNumber;
            postCode = newPostCode;
        }

        public string GetDescription()
        {
            string output;

            output = street + " " + streetNumber + ", " + postCode + " " + city;

            return output;
        }
    }
}
