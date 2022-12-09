using System;
using System.Collections.Generic;
using System.Linq;
using ToDoPruebaApi.Entities;

namespace ToDoPruebaApi.Services
{
    public interface IService<T>
    {
        public T GetById(Guid id);
        public void Add(T entity);
        public void Update(T entity, Guid id);
        public IEnumerable<T> GetAll();
        public void Delete(Guid id);
    }
    public class ToDoService : IService<Item>
    {
        private readonly List<Item> _items = new List<Item>();
        public void Add(Item entity)
        {
            entity.Id = Guid.NewGuid();
            _items.Add(entity);
        }

        public void Delete(Guid id)
        {
           _items.Remove(GetById(id));
           
        }

        public Item GetById(Guid id)
        {
            return _items.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Item entity, Guid id)
        {
            var result = GetById(id);
            result.Title = entity.Title;
            result.Description = entity.Description;
        }

        public IEnumerable<Item> GetAll()
        {
            return _items;
        }
    }
}
