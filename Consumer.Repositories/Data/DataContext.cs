using Consumer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consumer.Repositories
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) {}

        public DbSet<Immobile> properties { get; set; }
        public DbSet<Electric> electrics { get; set; }
    }
}