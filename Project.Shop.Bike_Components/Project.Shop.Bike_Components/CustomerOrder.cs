using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Project.Shop.Bike_Components
{
    class CustomerOrder
    {
        public void Order()
        {
            Console.WriteLine("Do you want to make order?");
            string _answer = Console.ReadLine();
            if (_answer == "yes")
            {
                MakeOrder();
            }
            else
            {
                return;
            }
        }

        public void MakeOrder()
        {
            Console.WriteLine("Please, write the model of bike or other parts for bike that you want to order and quantity!");
            var order = File.Exists("order.json");
            File.WriteAllText("order.json", JsonConvert.SerializeObject(order));
            //json
            Console.WriteLine("Please, enter your email adress");
            string _email = Console.ReadLine();

        }
    }
}
