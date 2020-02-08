using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Bike_Components
{
    class Customer
    {
        public string Name { get; set; }
        public string Item { get; set; }

        //public CustomerInfo

        public void PrintCustomerInfo()
        {
            Console.WriteLine("Hello! Welcom to our shop!");
            Console.WriteLine("Please, enter your name:");
            Name = Console.ReadLine();
            Console.WriteLine($"Can I help you, {Name}?");
            Console.WriteLine("We can help you to choose a bike according to your parameters.");
            Console.WriteLine($"Also, {Name}, you can choose Parts for your bike, Accessories or Clothing.");
            Console.WriteLine("Please, choose one of the four items: /Bike / Parts for bike/ Accessories / Clothing/.");
            Item = Console.ReadLine();
        }
    }
}
