using System;
using System.Reflection;

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
            }

            if (customer.Item=="Parts")
            {
                Parts parts = new Parts();
                //parts.
            }
            if (customer.Item == "Accessories")
            {
                Accessories accessories = new Accessories();
                //accessories.
            }
            if (customer.Item == "Clothes")
            {
                Clothes clothes = new Clothes();
                //clothes
            }

            //TwentySixSize=26,
            //TwentySevenSize = 27.5,

            Logger.Log.Info("PROGRAMM_COMPLETED_SUCCESSFULLY");
            Console.ReadLine();
        }
    }
}
