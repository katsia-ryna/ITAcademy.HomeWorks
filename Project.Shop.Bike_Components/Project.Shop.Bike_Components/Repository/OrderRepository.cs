using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project.Shop.Bike_Components
{
    public class OrderRepository : IOrderRepository
    {
        private string _fileName;
        private List<CustomerOrder> _item;

        public OrderRepository(string fileName)
        {
            _fileName = fileName;
            //using (var fileStream = new FileStream(_fileName, FileMode.OpenOrCreate))
            //{
            //    var sr = new StreamReader(fileStream);
            //    var strItems = sr.ReadToEnd();
            //    _item = JsonConvert.DeserializeObject<List< CustomerOrder>>(File.ReadAllText(_fileName));
            //}
            _item = JsonConvert.DeserializeObject<List<CustomerOrder>>(File.ReadAllText("orders.json"));
        }

        public void Create(CustomerOrder entity)
        {
            using (var fileStream = new FileStream(/*"orders.json"*/_fileName, FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(fileStream);
                var strOrders = sr.ReadToEnd();
                var orders = JsonConvert.DeserializeObject<List<CustomerOrder>>(strOrders);
                if (orders==null)
                {
                    orders = new List<CustomerOrder>();
                }
                orders.Add(entity);
                strOrders = JsonConvert.SerializeObject(orders);
                var sw = new StreamWriter(fileStream);
                sw.Write(strOrders);
                sw.Flush();
            }
        }

        public void Delete(int id)
        {
            var order = _item.FirstOrDefault(x => x.OrderId == id);
            if (order!=null)
            {
                _item.Remove(order);
            }
        }

        public IEnumerable<CustomerOrder> GetAll()
        {
            return JsonConvert.DeserializeObject<List<CustomerOrder>>(File.ReadAllText("orders.json"));
        }

        public CustomerOrder GetById(int id)
        {
            return _item.FirstOrDefault(x=>x.OrderId==id) ;
        }

        public void Update(CustomerOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
