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
            IBikeRepository bikeRepository = new BikeRepository();
            IOrderRepository orderRepository = new OrderRepository("orders.json");

            Console.WriteLine("Hello! Welcom to our shop!");
            Console.WriteLine("We can help you to choose a bike according to your parameters.");
            Console.WriteLine("Please, enter your name:");
            var name = "Kate";//Console.ReadLine();
            Console.WriteLine("Please, enter your phone number: ");
            var tel = "123477";// Console.ReadLine();
            Console.WriteLine("Please, enter your Email: ");
            var email = "bike@mail.com"; //Console.ReadLine();

            Customer customer = new Customer(name, tel, email);
            customer.PrintCustomerInfo();

            var bikes = bikeRepository.GetAll();
            Console.WriteLine();
            Console.WriteLine("Bikes list:");
            foreach (var bike in bikes)
            {
                bike.PrintBikeInfo();
                Console.WriteLine();
            }

            Console.WriteLine("You can make order");

            Console.WriteLine("Please, enter Bike Id, that you want to order");
            var id = 2; //Console.ReadLine();
            var bikeToOrder = bikes.FirstOrDefault(x => x.BikeId == id);

            if (bikeToOrder==null)
            {
                Console.WriteLine("Invalid Id");
                return;
            }
            
            Console.WriteLine("Enter Bike quantity");
            var quantity = 5; //Console.ReadLine();

            Console.WriteLine("Enter your address");
            var address = "address";//Console.ReadLine();


            CustomerOrder customerOrder = new CustomerOrder(bikeToOrder, customer, address, quantity);
            orderRepository.Create(customerOrder);

            Console.WriteLine("Your order has been created.");


            //Logger.InitLogger();
            //Logger.Log.Info(string.Concat("START_PROGRAMM:NAME " + Assembly.GetExecutingAssembly().GetName().Name
            //    + ", NAMESPACE " + Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace));

            //MyLogger.Log.Info("PROGRAMM_COMPLETED_SUCCESSFULLY");
            Console.ReadLine();
        }
    }
}