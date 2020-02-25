using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Project.Bike_Components
{

    public class CustomerOrder
    {
        public int OrderId { get; set; }

        public string Address { get; set; }

        public Bike Bike { get; set; }

        public int Quantity { get; set; }

        public Customer Customer { get; set; }

        public OrderStatus OrderStatus { get; set; } 

        public CustomerOrder(string address, int quantity,Bike  bike, Customer customer)
        {
            Address = address;
            Quantity = quantity;
            Bike = bike;
            Customer = customer;
        }
    }
}
