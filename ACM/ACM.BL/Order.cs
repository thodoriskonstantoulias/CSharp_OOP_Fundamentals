﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        //Validates order data
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid; 
        }
    }
}
