using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Project.Bike_Components
{
    class Parts : IThings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        public void PrintThingsInfo()
        {
            Console.WriteLine("All right!");
            Console.WriteLine("You can see the product that interests you in this list:");
            var obj = File.Exists("Parts.json") ? JsonConvert.DeserializeObject(File.ReadAllText("Parts.json"))
                : new List<Parts>()
                {
                new Parts()
                {

                    Name="Cassets",
                    
                },
                new Parts()
                {

                    Name="Chain",
                   
                }
                };
                

            Console.WriteLine(obj);
            Console.WriteLine(Name,Model);
        }
    }
}
