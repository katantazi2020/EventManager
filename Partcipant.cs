using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
     class Partcipant
    {
        private string firstName = string.Empty;
        private string lastName = "";

        private Address address;

        public Partcipant()
        {
            address = new Address();

        }
        public Partcipant(string firstName, string lastName, Address adr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (adr != null)
            address = adr;
            else
                address = new Address();
        }
        public Partcipant(Partcipant theother)
        {
            this.firstName=theother.firstName;
            this.lastName=theother.lastName;
            this.address = new Address(theother.address);
        }
        #region PROPERTIES
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion
        #region OTHER METHODS
        public bool Validate()
        {
            bool addrok = address.validate();
            bool namesOK = (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName);
            return addrok && namesOK;
        }
        public override string ToString()
        {
            string strout = string.Format("{0, -20} {1}", FirstName, LastName, address.ToString());
            return strout;
        }
        #endregion
    }
}
