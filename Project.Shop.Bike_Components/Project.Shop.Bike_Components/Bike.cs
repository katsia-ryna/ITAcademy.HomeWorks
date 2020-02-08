using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Bike_Components
{
    class Bike
    {
        public string Type { get; set; }

        public virtual void PrintBikeInfo()
        {
            Console.WriteLine("All right! Let's choose a bike!");
            Console.WriteLine("Please, choose one of the four types of bikes: /Mountain bike /Road bike /City bike /" +
                "/Kids bike/");
            Type = Console.ReadLine();
        }
    }
}
