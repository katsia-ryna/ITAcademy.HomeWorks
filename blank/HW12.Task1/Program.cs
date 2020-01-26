using System;

namespace HW12.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("GetMotorcycleByID");
            MotorcycleRepository repository = new MotorcycleRepository();

            Console.WriteLine("GetMotorcycleById from repository");
            var moto = repository.GetMotorcycleById(2);
            Print(moto);

            Console.WriteLine();
            repository.GetMotorcycles();
            repository.CreateMotorcycle(new Motorcycle()
            {
                Id = 4,
                Name = "Hors",
                Model = "F - 160",
                Year = 2018,
                Odometer = 4_100,
            });
            repository.UpdateMotorcycle(new Motorcycle()
            {
                Id = 1,
                Name = "Yamaha",
                Model = "LK100",
                Year = 2019,
                Odometer = 1_300,
            });
            repository.DeleteMotorcycle(3);

            Console.ReadLine();
         
        }
        static void Print(Motorcycle motorcycle)
        {
            Console.WriteLine($" id = {motorcycle.Id}, name={motorcycle.Name}, model= {motorcycle.Model}, " +
                $"year= {motorcycle.Year}");
  
        }
    }
}
