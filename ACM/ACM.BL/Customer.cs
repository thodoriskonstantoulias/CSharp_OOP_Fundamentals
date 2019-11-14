﻿using System;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        {
            get 
            { 
                return LastName + "," + FirstName;
            }
        }
        public static int InstanceCount { get; set; }
    }
}
