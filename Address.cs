using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    internal class Address
    {
        private string street;
        private string ZipCode;
        private string City;
        private Countries country;

        public Address(string street, string Zip, string City, Countries Country)
        {
            this.street = street;
            this.ZipCode = Zip;
            this.City = City;
            this.Country = Country;
        }
        public Address(string street, string Zip, string City) :
        
            this(street, Zip, City, Countries.Sverige)
        {

        }
        public Address() : this(string.Empty,string.Empty, string.Empty)
        {

        }
        public Address(Address theother)
        {
            this.street=theother.street;
            this.ZipCode = theother.ZipCode;
            this.City = theother.City;

        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string city
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    city = value;
            }
        }
        public string Zipcode
        {
            get { return Zipcode; }
            set { Zipcode = value; }
        }
       public Countries Country
        {
            get { return Country; }
            set { Country = value; }
        }
        public bool validate()
        {
            bool cityok = !string.IsNullOrEmpty(City);
            return cityok;
        }
        public  string GetAddressLabel()
        {
            string strout = street + Environment.NewLine;
            strout += Zipcode + " " + city;
            return strout;
        }
        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }
        public override string ToString()
        {
            string strout = string.Format("{0, -25} {1, -8} {2, -10} {3}", street, Zipcode, city, GetCountryString());
            return strout;
        }



    }
}
