using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Project.Bike_Components
{
    class CityBike : Bike
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("model")]
        public string[] Model { get; set; }

        public override void PrintBikeInfo()
        {
            Console.WriteLine("All right!");
            Console.WriteLine("You can see the product that interests you in this list:");
            var obj = JsonConvert.DeserializeObject(File.ReadAllText("CB.json"));
            Console.WriteLine(obj);
        }
    }
}
