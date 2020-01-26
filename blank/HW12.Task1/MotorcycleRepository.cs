using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HW12.Task1
{
    class MotorcycleRepository
    {
        private List<Motorcycle> _list = new List<Motorcycle>();
        public MotorcycleRepository()
        {
            _list = new List<Motorcycle>()
            {
                new Motorcycle()
                {
                    Id=1,
                    Name="Yamaha",
                    Model="Xj6N",
                    Year=2016,
                    Odometer=8_200,
                },
                new Motorcycle()
                {
                    Id=2,
                    Name="Stels",
                    Model="Flex200",
                    Year=2017,
                    Odometer=12_100,
                },
                new Motorcycle()
                {
                    Id=3,
                    Name="Kawasaki",
                    Model="Z1000",
                    Year=2013,
                    Odometer=24_100,
                }
            };
        }

        public Motorcycle GetMotorcycleById(int id)
        {
            //Console.WriteLine(motorcycle);
            return _list.FirstOrDefault(x=>x.Id==id);
        }
        public void GetMotorcycles()
        {
            foreach (var motorcycle in _list)
            {
                Console.WriteLine($"{motorcycle.Id}, {motorcycle.Name}, {motorcycle.Model}, {motorcycle.Year}," +
                    $" {motorcycle.Odometer}");
            }
        }
        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            _list.Add(motorcycle);
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            var existingMotorcycle = _list.FirstOrDefault(x=>x.Id==motorcycle.Id);
            if (existingMotorcycle==null)
            {
                return;
            }
            existingMotorcycle.Model = motorcycle.Model;
            existingMotorcycle.Name = motorcycle.Name;
            existingMotorcycle.Year = motorcycle.Year;
            existingMotorcycle.Odometer = motorcycle.Odometer;
        }

        public void DeleteMotorcycle(int id)
        {
            var motorcycle = _list.FirstOrDefault(x => x.Id == id);
            if (motorcycle==null)
            {
                return;
            }
            else
            {
                _list.Remove(motorcycle);
            }
        }
    }
}
