using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        //Retrieve one customer 
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            //Code to find appropriate customer 

            //Hardcoded data for now
            if (customerId == 1)
            {
                customer.Email = "ted@gmail.com";
                customer.FirstName = "Ted";
                customer.LastName = "Kos";
            }
            return customer;
        }
        //Saves the current customer
        public bool Save(Customer customer)
        {
            //Code that saves the passed in customer
            return true;
        }
    }
}
