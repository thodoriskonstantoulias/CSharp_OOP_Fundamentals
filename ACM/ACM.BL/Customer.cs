using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer():this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }      
        public int CustomerId { get; private set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public string FullName 
        {
            get 
            { 
                return LastName + "," + FirstName;
            }
        }
        public static int InstanceCount { get; set; }

        //Validates customer's data
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(Email)) isValid = false;

            return isValid;
        }

    }
}
