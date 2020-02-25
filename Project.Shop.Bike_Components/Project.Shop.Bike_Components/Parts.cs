using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Project.Bike_Components
{
    //class Parts
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("model")]
    //    public string[] Model { get; set; }

    //    private List<Parts> _listParts = new List<Parts>();
     
    //    public void PrintThingsInfo()
    //    {
    //        Console.WriteLine("All right!");
    //        Console.WriteLine("You can see the product that interests you in this list:");

    //        var parts = File.Exists("Parts.json") ? JsonConvert.DeserializeObject(File.ReadAllText("Parts.json")): _listParts;
    //        _listParts.Add(new Parts() { Name = "Chains", Model = new string[] { "Shimano 11", "Sram 11", "Sram 10", "Sram 12" } });
    //        _listParts.Add(new Parts() { Name = "Casetts", Model = new string[] { "Shimano Ultegro", "Shimano CS", "Sram 105", "Sram GX" } });
    //        _listParts.Add(new Parts() { Name = "Brakes", Model = new string[] { "Shimano XT", "Magura MT7", "Shimano BR-M820", "Magura MT5" } });
    //        _listParts.Add(new Parts() { Name = "Seatposts", Model = new string[] { "Thomson Elite", "Suntour NCx", "Oneup Components", "Thomson BN" } });
    //        _listParts.Add(new Parts() { Name = "Wheels", Model = new string[] { "Evolution disk 29\"", "Shimano WH-R501", "Mavic Acsium", "Mavic Crossride" } });

    //        File.WriteAllText("Parts.json", JsonConvert.SerializeObject(parts));
    //        Console.WriteLine(parts);

    //        /*foreach (var item in _listParts)
    //        {
    //           for (int i = 0; i < 4; i++)
    //           {
    //              Console.WriteLine($"Name = {item.Name}, Model = {item.Model[i]}");
    //           }
    //        }*/
    //    }
    //}
}
