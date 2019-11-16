using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    //Different class for the repository to understand the separation of concerns
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            //Code to find appropriate order 

            //Hardcoded data for now
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 0, 0, new TimeSpan(7, 0, 0));
            }
            return order;
        }
        //Saves the current order
        public bool Save(Order order)
        {
            //Code that saves the passed in order
            return true;
        }
    }
}
