using Polymorphism.Models;

namespace Polymorphism.Repository;
public interface IOrderRepository
{
    void Add(Order order);
    void Update(Order order);
    void Delete(Order order);
    void GetAll();
}
