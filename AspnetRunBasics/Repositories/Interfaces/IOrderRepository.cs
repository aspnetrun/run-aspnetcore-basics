using System.Collections.Generic;
using System.Threading.Tasks;
using AspnetRunBasics.Entities;

namespace AspnetRunBasics.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> CheckOut(Order order);
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
