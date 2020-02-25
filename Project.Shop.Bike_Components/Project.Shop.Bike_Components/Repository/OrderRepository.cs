using Newtonsoft.Json;
using Project.Bike_Components;
using System;
using System.Collections.Generic;
using System.IO;

namespace Project.Shop.Bike_Components.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void Create(CustomerOrder entity)
        {
            using (var fileStream = new FileStream("orders.json", FileMode.OpenOrCreate))
            {
                var sr = new StreamReader(fileStream);
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
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerOrder> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerOrder GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
