using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Project.Shop.Bike_Components
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Create(T entity);

        void Delete(int id);

        void Update(T entity);
    }
}
