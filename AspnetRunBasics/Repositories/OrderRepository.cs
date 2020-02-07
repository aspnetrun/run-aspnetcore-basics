using AspnetRunBasics.Data;
using AspnetRunBasics.Entities;
using System;
using System.Threading.Tasks;

namespace AspnetRunBasics.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        protected readonly AspnetRunContext _dbContext;

        public OrderRepository(AspnetRunContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Order> CheckOut(Order order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return order;            
        }
    }
}
