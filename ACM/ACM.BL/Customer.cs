using Acme.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer: EntityBase, ILoggable
    {
        //Overloading constructors
        public Customer():this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }      

        //Defining getters and setters
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
        //Instance count is defined as static because we want it to not get initialized after each instance
        public static int InstanceCount { get; set; }

        //Validates customer's data
        //Overrides the parent class abstract method
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(Email)) isValid = false;

            return isValid;
        }
        //Log method to show the use of interfaces 
        public string Log()
        {
            return $"{CustomerId} : {FullName} Email : {Email} Status :  {EntityState.ToString()}";
        }

    }
}
