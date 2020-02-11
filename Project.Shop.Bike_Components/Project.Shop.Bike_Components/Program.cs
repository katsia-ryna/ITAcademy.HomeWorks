using System;
using System.Reflection;
using Newtonsoft.Json;
using MyLogger;


namespace Project.Bike_Components
{
    enum FrameSize
    {
        XSmall = 13,
        Small = 16,
        Medium = 18,
        Large = 20,
        XLarge = 22
    }

    struct WheelSize
    {
        public float wheel1;

        public void PrintWheelSize()
        {
            Console.WriteLine($"You should choose a bike whith a wheel size of {wheel1}\"");
        }
        public void PrintTwoWheelSizes()
        {
            Console.WriteLine($"You should choose a bike whith a wheel size of {wheel1}\" or 28\"");
        }
    }

    class Program
    {
        static void Main()
        {
            Log log = new Log();
            LogDelegate logDelegate = Log.Info;
            
            
            MyLogger.Log.Info("kkk");
            //Logger.InitLogger();
            //Logger.Log.Info(string.Concat("START_PROGRAMM:NAME " + Assembly.GetExecutingAssembly().GetName().Name
            //    + ", NAMESPACE " + Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace));


            Customer customer = new Customer();
            //MyLogger.Log.Debug("PrintCustomerInfo method call");
            customer.PrintCustomerInfo();

            if (customer.Item == "Bike" || customer.Item == "bike")
            {
                //MyLogger.Log.Debug("Bike class call");
                Bike bike = new Bike();
                bike.PrintBikeInfo();
                if (bike.Type == "Mountain bike" || bike.Type == "mountain bike")
                {
                    //MyLogger.Log.Debug("MountainBike class call");
                    MountainBike mountain = new MountainBike();
                    mountain.PrintBikeInfo();
                }
                if (bike.Type == "Road bike" || bike.Type == "road bike")
                {
                    //MyLogger.Log.Debug("RoadBike class call");
                    RoadBike roadBike = new RoadBike();
                    roadBike.PrintBikeInfo();
                }
                if (bike.Type == "City bike" || bike.Type == "city bike")
                {
                    //MyLogger.Log.Debug("CityBike class call");
                    CityBike cityBike = new CityBike();
                    cityBike.PrintBikeInfo();
                }
                if (bike.Type == "Kids bike" || bike.Type == "kids bike")
                {
                    //MyLogger.Log.Debug("KidsBike class call");
                    KidsBike kidsBike = new KidsBike();
                    kidsBike.PrintBikeInfo();
                }

                //MyLogger.Log.Debug(" ");
                Console.WriteLine("We'll help you choose a bike according to your parameters");
                Console.WriteLine("Enter your height:");
                float height = Convert.ToSingle(Console.ReadLine());
                WheelSize wheelSize;

                if (height >= 120f & height <= 157f)
                {
                    FrameSize frameSize = FrameSize.XSmall;
                    Console.WriteLine($"You should choose a frame size of {(int)frameSize}\" or {(int)frameSize + 1}\"");
                    wheelSize.wheel1 = 24f;
                    wheelSize.PrintWheelSize();
                }
                if (height >= 158f & height <= 168f)
                {
                    FrameSize frameSize = FrameSize.Small;
                    Console.WriteLine($"You should choose a frame size of {(int)frameSize - 1}\" or {(int)frameSize}\"");
                    wheelSize.wheel1 = 26;
                    wheelSize.PrintWheelSize();
                }
                if (height >= 169f & height <= 178f)
                {
                    FrameSize frameSize = FrameSize.Medium;
                    Console.WriteLine($"You should choose a frame size of {(int)frameSize - 1}\" or {(int)frameSize}\"");
                    wheelSize.wheel1 = 27.5f;
                    wheelSize.PrintTwoWheelSizes();
                }
                if (height >= 179f & height <= 188f)
                {
                    FrameSize frameSize = FrameSize.Large;
                    Console.WriteLine($"You should choose a frame size of {(int)frameSize - 1}\" or {(int)frameSize}\"");
                    wheelSize.wheel1 = 29;
                    wheelSize.PrintWheelSize();
                }
                if (height >= 189f & height <= 225f)
                {
                    FrameSize frameSize = FrameSize.XLarge;
                    Console.WriteLine($"You should choose a frame size of {(int)frameSize - 1}\" or {(int)frameSize}\"");
                    wheelSize.wheel1 = 29;
                    wheelSize.PrintWheelSize();
                }
                try
                {
                    if (height > 225f)
                    {
                        throw new Exception("Sorry, but we don't have a bike to yours parameters.");
                    }
                }
                catch (Exception ex)
                {
                    //MyLogger.Log.Error($"{ex.Message}");
                    Console.WriteLine($"{ex.Message}");
                    throw new Exception("Sorry, but we don't have a bike to yours parameters.");
                }
            }

            if (customer.Item == "Parts for bike" || customer.Item == "parts for bike")
            {
                Parts parts = new Parts();
                parts.PrintThingsInfo();
            }
            if (customer.Item == "Accessories" || customer.Item == "accessories")
            {
                Accessories accessories = new Accessories();
                accessories.PrintThingsInfo();
            }
          



            //MyLogger.Log.Info("PROGRAMM_COMPLETED_SUCCESSFULLY");
            Console.ReadLine();
        }
    }
}