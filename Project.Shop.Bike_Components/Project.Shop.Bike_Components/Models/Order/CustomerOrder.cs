using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Project.Shop.Bike_Components
{

    public class CustomerOrder
    {
        public int OrderId { get; set; }

        public string Address { get; set; }

        public Bike Bike { get; set; }

        public int Quantity { get; set; }

        public Customer Customer { get; set; }

        public OrderStatus OrderStatus { get; set; } 

        public CustomerOrder(Bike bike, Customer customer, string address, int quantity)
        {
            Address = address;
            Quantity = quantity;
            Bike = bike;
            Customer = customer;
        }
        public void PrintOrderInfo()
        {
            Console.WriteLine("Order info:");
            Console.WriteLine($"OrderId={OrderId}");
            Console.WriteLine($"Address={Address}");
            Console.WriteLine("Bike:");
            Bike.PrintBikeInfo();
            Console.WriteLine("Customer:");
            Customer.PrintCustomerInfo();
        }
    }
}
