using Consumer.Domain.Entities;

namespace Consumer.Repositories
{
    public interface IElectricRepository : IBaseRepository<Electric>
    {
        Electric GetMax();
        Electric GetMin();
  }
}