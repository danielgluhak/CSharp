using System;
using System.Collections.Generic;
using System.Text;

namespace CSProjectNo1.Person
{
    class Customer
    {
        private String firstName;
        private String lastName;
        private Boolean isMale;

        public Customer(string firstName, string lastName, bool isMale)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IsMale = isMale;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public bool IsMale { get => isMale; set => isMale = value; }
    }
}
