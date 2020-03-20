using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Project.Shop.Bike_Components
{
    class MountainBike : Bike
    {
        public override string Type { get; set; } = "Mountain bike";
    }
}
