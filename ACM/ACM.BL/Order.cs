using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        //Overloading constructors
        public Order() : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        //Defining getters and setters
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        //Log method to show the use of interfaces 
        public string Log()
        {
            return $"{OrderId} : {OrderDate.Value.Date} Status :  {EntityState.ToString()}";
        }

        //Validates order data
        //Overrides the parent class abstract method
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid; 
        }
    }
}
