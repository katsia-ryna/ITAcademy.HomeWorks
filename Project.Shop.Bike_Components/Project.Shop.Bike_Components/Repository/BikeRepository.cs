using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Project.Shop.Bike_Components
{
    class BikeRepository : IBikeRepository
    {
        private string _fileName;
        private List<Bike> _items;

        public BikeRepository(string fileName)
        {
            _fileName = fileName;
            using (FileStream fileStream=new FileStream(_fileName,FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(fileStream);
                var strItem = sr.ReadToEnd();
                _items = JsonConvert.DeserializeObject<List<Bike>>(strItem)?? new List<Bike>();
            }
        }

        public void Create(Bike entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Logger.Log.Info("Remove bike by id");
            var itemBike = _items.FirstOrDefault(x=>x.BikeId==id);
            if (itemBike!=null)
            {
                _items.Remove(itemBike);
            }
        }

        public IEnumerable<Bike> GetAll()
        {
            Logger.Log.Debug("Read file bikes.json");
            return JsonConvert.DeserializeObject<List<Bike>>(File.ReadAllText(_fileName));
        }

        public Bike GetById(int id)
        {
            Logger.Log.Info("Print bike by id");
            return _items.FirstOrDefault(x=>x.BikeId==id);
        }

        public void Update(Bike entity)
        {
            throw new NotImplementedException();
        }
    }
}
