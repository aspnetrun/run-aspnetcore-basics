using AspnetRunBasics.Entities;
using System.Threading.Tasks;

namespace AspnetRunBasics.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> CheckOut(Order orderModel);
    }
}
