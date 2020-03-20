using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shop.Bike_Components
{
    public class Bike
    {
        [JsonProperty("bike-id")]
        public int BikeId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("type")]
        public virtual string Type { get; set; }

        [JsonProperty("wheel-size")]
        public WheelSize WheelSize { get; set; }

        [JsonProperty("frame-size")]        
        public FrameSize FrameSize { get; set; }

        public virtual void PrintBikeInfo()
        {
            Console.WriteLine("Bike info:");
            Console.WriteLine($"BikeId={BikeId}");
            Console.WriteLine($"Model={Model}");
            Console.WriteLine($"Type={Type}");
            Console.WriteLine($"Wheel size={WheelSize.ToString()}");
            Console.WriteLine($"Frame size={FrameSize.ToString()}");
        }
    }
}
