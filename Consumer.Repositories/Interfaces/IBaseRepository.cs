using System.Collections.Generic;

namespace Consumer.Repositories
{
    public interface IBaseRepository<Entity> where Entity: class
    {
        void Create(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
        List<Entity> GetAll();
        Entity GetByID(int id);
  }
}