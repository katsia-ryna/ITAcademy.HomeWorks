using System;

namespace HW12.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcycleRepository repository = new MotorcycleRepository();

            repository.GetMotorcycleById(2);
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
    }
}
