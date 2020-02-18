using System;
using System.Reflection;

namespace HW12.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info(string.Concat("START_PROGRAMM:NAME " + Assembly.GetExecutingAssembly().GetName().Name + ", NAMESPACE " + Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace));
       
            MotorcycleRepository repository = new MotorcycleRepository();

            Logger.Log.Info("Get motorcycle by id");
            var moto = repository.GetMotorcycleById(2);
            Print(moto);

            Logger.Log.Info("Get all motorcycles");
            repository.GetMotorcycles();

            Logger.Log.Info("Create new motorcycle");
            repository.CreateMotorcycle(new Motorcycle()
            {
                Id = 4,
                Name = "Hors",
                Model = "F - 160",
                Year = 2018,
                Odometer = 4_100,
            });

            Logger.Log.Info("Update motorcycle");
            repository.UpdateMotorcycle(new Motorcycle()
            {
                Id = 1,
                Name = "Yamaha",
                Model = "LK100",
                Year = 2019,
                Odometer = 1_300,
            });

            Logger.Log.Info("Delete motorcycle");
            repository.DeleteMotorcycle(3);

            Logger.Log.Info("PROGRAMM_COMPLETED_SUCCESSFULLY");
            Console.ReadLine();
         
        }
        static void Print(Motorcycle motorcycle)
        {
            Console.WriteLine($" id = {motorcycle.Id}, name={motorcycle.Name}, model= {motorcycle.Model}, " +
                $"year= {motorcycle.Year}, odometer={motorcycle.Odometer}");
  
        }
    }
}
