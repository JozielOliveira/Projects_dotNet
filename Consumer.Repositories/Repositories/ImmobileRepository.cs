using System.Collections.Generic;
using System.Linq;
using Consumer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consumer.Repositories
{
  public class ImmobileRepository: IImmobileRepository
    {
        private DataContext context;

        public ImmobileRepository(DataContext context)
        {
            this.context = context;
        }

        public ImmobileRepository(){}

        public void Create(Immobile immobile)
        {
            context.properties.Add(immobile);
            context.SaveChanges();
        }

        public List<Immobile> GetAll()
        {
            return context.properties.ToList();
        }

        public Immobile GetByID(int id)
        {
            return context.properties.SingleOrDefault(Immobile => Immobile.id == id);
        }
        
        public void Update(Immobile Immobile)
        {
            context.Entry(Immobile).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.properties.Remove(GetByID(id));
            context.SaveChanges();
        }
  }
}
