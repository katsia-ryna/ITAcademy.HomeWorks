using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Project.Bike_Components
{
    class Accessories : IThings
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("model")]
        public string Model { get; set; }

        public void PrintThingsInfo()
        {
            Console.WriteLine("All right!");
            Console.WriteLine("You can see the product that interests you in this list:");
            var obj = JsonConvert.DeserializeObject(File.ReadAllText("Accessories.json"));
            Console.WriteLine(obj);
        }
    }
}