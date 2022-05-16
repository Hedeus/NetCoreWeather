using NetCoreWeather.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreWeather.Services.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T item);

        IEnumerable<T> GetAll();

        T Get(int id)
        {
            return GetAll().FirstOrDefault(item => item.Id == id);
        }

        void Remove(T item);

        void Update(int id, T item);
    }
}
