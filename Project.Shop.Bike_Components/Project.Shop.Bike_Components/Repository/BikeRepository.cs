using Newtonsoft.Json;
using Project.Bike_Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project.Shop.Bike_Components.Repository
{
    class BikeRepository : IBikeRepository
    {
        public void Create(Bike entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bike> GetAll()
        {
            return JsonConvert.DeserializeObject<List<Bike>>(File.ReadAllText("bikes.json"));
        }

        public Bike GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Bike entity)
        {
            throw new NotImplementedException();
        }
    }
}
