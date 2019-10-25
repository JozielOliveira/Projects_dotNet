using System.Collections.Generic;
using System.Linq;
using Consumer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consumer.Repositories
{
  public class ElectricRepository: IElectricRepository
    {
        private DataContext context;

        public ElectricRepository(DataContext context)
        {
            this.context = context;
        }

        public ElectricRepository(){}

        public void Create(Electric electric)
        {
            context.electrics.Add(electric);
            context.SaveChanges();
        }

        public List<Electric> GetAll()
        {
            return context.electrics.ToList();
        }

        public Electric GetMax()
        {
            return context.electrics.OrderByDescending(electric => electric.kwConsumed).FirstOrDefault();
        }

        public Electric GetMin()
        {
            return context.electrics.OrderBy(electric => electric.kwConsumed).FirstOrDefault();
        }

        public Electric GetByID(int id)
        {
            return context.electrics.SingleOrDefault(electric => electric.id == id);
        }
        
        public void Update(Electric electric)
        {
            context.Entry(electric).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.electrics.Remove(GetByID(id));
            context.SaveChanges();
        }
  }
}
