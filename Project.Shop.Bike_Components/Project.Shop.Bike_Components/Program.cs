using System;
using System.Reflection;
using Newtonsoft.Json;
using MyLogger;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.Shop.Bike_Components.Repository;
using Project.Shop.Bike_Components;
using Shop.Bike_Components.Admin;

namespace Project.Bike_Components
{
    class Program
    {
        static void Main()
        {
            IBikeRepository bikeRepository = new BikeRepository();
            IOrderRepository orderRepository = new OrderRepository();

            Console.WriteLine("Hello! Welcom to our shop!");
            Console.WriteLine("We can help you to choose a bike according to your parameters.");
            Console.WriteLine("Please, enter your name:");
            var name = "Kate";//Console.ReadLine();
            Console.WriteLine("Please, enter your phone number: ");
            var tel = "123477";// Console.ReadLine();
            Console.WriteLine("Please, enter your Email: ");
            var email = "bike@mail.com"; //Console.ReadLine();

            var customer = new Customer(name, tel, email);
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

            
            var customerOrder = new CustomerOrder(address, quantity, bikeToOrder, customer);
            orderRepository.Create(customerOrder);

            Console.WriteLine("Your order has been created.");



            
            //Console.WriteLine("All right! Let's choose a bike!");
            //Console.WriteLine("Please, choose one of the four types of bikes: /Mountain bike /Road bike /City bike /" +
            //    "/Kids bike/");
            //Type = Console.ReadLine();


            //public void Order()
            //{
            //    Console.WriteLine("Do you want to make order?");
            //    string _answer = Console.ReadLine();
            //    if (_answer == "yes")
            //    {
            //        MakeOrder();
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}

            //public void MakeOrder()
            //{
            //    Console.WriteLine("Please, write the model of bike or other parts for bike that you want to order and quantity!");
            //    var order = File.Exists("order.json");
            //    File.WriteAllText("order.json", JsonConvert.SerializeObject(order));
            //    //json
            //    Console.WriteLine("Please, enter your email adress");
            //    string _email = Console.ReadLine();

            //}


            //Log log = new Log();
            //LogDelegate logDelegate = Log.Info;
            //MyLogger.Log.Info("pppppppp");

            //Logger.InitLogger();
            //Logger.Log.Info(string.Concat("START_PROGRAMM:NAME " + Assembly.GetExecutingAssembly().GetName().Name
            //    + ", NAMESPACE " + Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace));


            //Customer customer = new Customer();
            ////MyLogger.Log.Debug("PrintCustomerInfo method call");
            //customer.PrintCustomerInfo();

            //if (customer.Item == "Bike" || customer.Item == "bike")
            //{
            //    //MyLogger.Log.Debug("Bike class call");
            //    Bike bike = new Bike();
            //    bike.PrintBikeInfo();
            //    if (bike.Type == "Mountain bike" || bike.Type == "mountain bike")
            //    {
            //        //MyLogger.Log.Debug("MountainBike class call");
            //        MountainBike mountain = new MountainBike();
            //        mountain.PrintBikeInfo();
            //    }
            //    if (bike.Type == "Road bike" || bike.Type == "road bike")
            //    {
            //        //MyLogger.Log.Debug("RoadBike class call");
            //        RoadBike roadBike = new RoadBike();
            //        roadBike.PrintBikeInfo();
            //    }
            //    if (bike.Type == "City bike" || bike.Type == "city bike")
            //    {
            //        //MyLogger.Log.Debug("CityBike class call");
            //        CityBike cityBike = new CityBike();
            //        cityBike.PrintBikeInfo();
            //    }
            //    if (bike.Type == "Kids bike" || bike.Type == "kids bike")
            //    {
            //        //MyLogger.Log.Debug("KidsBike class call");
            //        KidsBike kidsBike = new KidsBike();
            //        kidsBike.PrintBikeInfo();
            //    }

            //    //MyLogger.Log.Debug(" ");
            //    Console.WriteLine("We'll help you choose a bike according to your parameters");
            //    Console.WriteLine("Enter your height:");
            //    float height = Convert.ToSingle(Console.ReadLine());
            //    WheelSize wheelSize;

            //    if (height >= 120f & height <= 157f)
            //    {
            //        FrameSize frameSize = FrameSize.XSmall;
            //        Console.WriteLine($"You should choose a frame size of {(int)frameSize}\" or {(int)frameSize + 1}\"");
            //        wheelSize.wheel1 = 24f;
            //        wheelSize.PrintWheelSize();
            //    }
            //    if (height >= 158f & height <= 168f)
            //    {
            //        FrameSize frameSize = FrameSize.Small;
            //        Console.WriteLine($"You should choose a frame size of {(int)frameSize - 1}\" or {(int)frameSize}\"");
            //        wheelSize.wheel1 = 26;
            //        wheelSize.PrintWheelSize();
            //    }
            //    if (height >= 169f & height <= 178f)
            //    {
            //        FrameSize frameSize = FrameSize.Medium;
            //        Console.WriteLine($"You should choose a frame size of {(int)frameSize - 1}\" or {(int)frameSize}\"");
            //        wheelSize.wheel1 = 27.5f;
            //        wheelSize.PrintTwoWheelSizes();
            //    }
            //    if (height >= 179f & height <= 188f)
            //    {
            //        FrameSize frameSize = FrameSize.Large;
            //        Console.WriteLine($"You should choose a frame size of {(int)frameSize - 1}\" or {(int)frameSize}\"");
            //        wheelSize.wheel1 = 29;
            //        wheelSize.PrintWheelSize();
            //    }
            //    if (height >= 189f & height <= 225f)
            //    {
            //        FrameSize frameSize = FrameSize.XLarge;
            //        Console.WriteLine($"You should choose a frame size of {(int)frameSize - 1}\" or {(int)frameSize}\"");
            //        wheelSize.wheel1 = 29;
            //        wheelSize.PrintWheelSize();
            //    }
            //    try
            //    {
            //        if (height > 225f)
            //        {
            //            throw new Exception("Sorry, but we don't have a bike to yours parameters.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        //MyLogger.Log.Error($"{ex.Message}");
            //        Console.WriteLine($"{ex.Message}");
            //        throw new Exception("Sorry, but we don't have a bike to yours parameters.");
            //    }
            //}

            //if (customer.Item == "Parts for bike" || customer.Item == "parts for bike")
            //{
            //    Parts parts = new Parts();
            //    parts.PrintThingsInfo();
            //}
            //if (customer.Item == "Accessories" || customer.Item == "accessories")
            //{
            //    Accessories accessories = new Accessories();
            //    accessories.PrintThingsInfo();
            //}

            //MyLogger.Log.Info("PROGRAMM_COMPLETED_SUCCESSFULLY");
            Console.ReadLine();
        }
    }
}