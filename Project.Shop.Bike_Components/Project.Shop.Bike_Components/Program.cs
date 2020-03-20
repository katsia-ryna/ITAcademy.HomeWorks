using System;
using System.Reflection;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project.Shop.Bike_Components
{
    class Program
    {
        static void Main()
        {
            Logger.InitLogger();
            Logger.Log.Info(string.Concat("START_PROGRAMM:NAME " + Assembly.GetExecutingAssembly().GetName().Name
                + ", NAMESPACE " + Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace));
            
            IBikeRepository bikeRepository = new BikeRepository("bikes.json");
            IOrderRepository orderRepository = new OrderRepository("orders.json");

            Console.WriteLine("Hello! Welcom to our shop!");
            Console.WriteLine("We can help you to choose a bike according to your parameters.");
            Console.WriteLine("Please, enter your name:");
            var name = Console.ReadLine();
            Console.WriteLine("Please, enter your phone number: ");
            var tel = Console.ReadLine();
            Console.WriteLine("Please, enter your Email: ");
            var email = Console.ReadLine();

            Logger.Log.Debug("Customer class call");
            Customer customer = new Customer(name, tel, email);
            customer.PrintCustomerInfo();

            Logger.Log.Debug("BikeRepository class call");
            var bikes = bikeRepository.GetAll();
            Console.WriteLine();
            Console.WriteLine("Bikes list:");
            Logger.Log.Info("Print Bikes list");
            foreach (var bike in bikes)
            {
                bike.PrintBikeInfo();
                Console.WriteLine();
            }

            Console.WriteLine("You can make order");
            Console.WriteLine("Please, enter Bike Id, that you want to order");
            var id = Convert.ToInt32(Console.ReadLine());
            var bikeToOrder = bikes.FirstOrDefault(x => x.BikeId == id);

            if (bikeToOrder==null)
            {
                Logger.Log.Error("Incorrect id number");
                Console.WriteLine("Invalid Id");
                return;
            }
            
            Console.WriteLine("Enter Bike quantity");
            var quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your address");
            var address = Console.ReadLine();

            CustomerOrder customerOrder = new CustomerOrder(bikeToOrder, customer, address, quantity);
            Logger.Log.Info("Create customer order");
            orderRepository.Create(customerOrder);
            Console.WriteLine("Your order has been created.");

            Logger.Log.Info("PROGRAMM_COMPLETED_SUCCESSFULLY");
            Console.ReadLine();
        }
    }
}