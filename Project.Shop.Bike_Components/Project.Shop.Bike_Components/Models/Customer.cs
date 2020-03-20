using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shop.Bike_Components
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public Customer(string name, string tel, string email)
        {
            Name = name;
            Tel = tel;
            Email = email;
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine("Customer info:");
            Console.WriteLine($"Name={Name}");
            Console.WriteLine($"Tel={Tel}");
            Console.WriteLine($"Email={Email}");
        }
    }


}
