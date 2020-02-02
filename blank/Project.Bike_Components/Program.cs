using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Project.Bike_Components
{
    enum FrameSize
    {
        XSmall=13,
        Small=16,
        Medium=18,
        Large=20,
        XLarge=22
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
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info(string.Concat("START_PROGRAMM:NAME " + Assembly.GetExecutingAssembly().GetName().Name 
                + ", NAMESPACE " + Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace));
            Logger.Log.Debug("");
            Logger.Log.Error("");

            Customer customer = new Customer();
            customer.PrintCustomerInfo();

            if (customer.Item=="Bike" || customer.Item=="bike")
            {
                Bike bike = new Bike();
                bike.PrintBikeInfo();
                if (bike.Type=="Mountain bike" || bike.Type == "mountain bike")
                {
                    MountainBike mountain = new MountainBike();
                    mountain.PrintBikeInfo();
                }
                if (bike.Type == "Road bike" || bike.Type=="road bike")
                {
                    RoadBike roadBike = new RoadBike();
                    roadBike.PrintBikeInfo();
                }
                if (bike.Type=="City bike" || bike.Type=="city bike")
                {
                    CityBike cityBike = new CityBike();
                    cityBike.PrintBikeInfo();
                }
                if (bike.Type=="Kids bike" || bike.Type=="kids bike")
                {
                    KidsBike kidsBike = new KidsBike();
                    kidsBike.PrintBikeInfo();
                }

                Console.WriteLine("We'll help you choose a bike according to your parameters");
                Console.WriteLine("Enter your height:");
                float height = Convert.ToSingle(Console.ReadLine());
                WheelSize wheelSize;

                if (height >= 120f & height <= 157f)
                {
                    FrameSize frameSize = FrameSize.XSmall;
                    Console.WriteLine($"You should choose a frame size of {(int)frameSize}\" or {(int)frameSize+1}\"");
                    wheelSize.wheel1 = 24f;
                    wheelSize.PrintWheelSize();
                }
                if (height >= 158f & height <= 168f)
                {
                    FrameSize frameSize = FrameSize.Small;
                    Console.WriteLine($"You should choose a frame size of {(int)frameSize-1}\" or {(int)frameSize}\"");
                    wheelSize.wheel1 = 26;
                    wheelSize.PrintWheelSize();
                }
                if (height >= 169f & height <= 178f)
                {
                    FrameSize frameSize = FrameSize.Medium;
                    Console.WriteLine($"You should choose a frame size of {(int)frameSize-1}\" or {(int)frameSize}\"");
                    wheelSize.wheel1 = 27.5f;
                    wheelSize.PrintTwoWheelSizes();
                }
                if (height >= 179f & height <= 188f)
                {
                    FrameSize frameSize = FrameSize.Large;
                    Console.WriteLine($"You should choose a frame size of {(int)frameSize-1}\" or {(int)frameSize}\"");
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
                        Logger.Log.Error($"{ex.Message}");
                        Console.WriteLine($"{ex.Message}");
                }
            }

            if (customer.Item=="Parts")
            {
                Parts parts = new Parts();
                parts.PrintThingsInfo();
            }
            if (customer.Item == "Accessories")
            {
                Accessories accessories = new Accessories();
                accessories.PrintThingsInfo();
            }
            if (customer.Item == "Clothes")
            {
                Clothes clothes = new Clothes();
                clothes.PrintThingsInfo();
            }



            Logger.Log.Info("PROGRAMM_COMPLETED_SUCCESSFULLY");
            Console.ReadLine();
        }
    }
}
