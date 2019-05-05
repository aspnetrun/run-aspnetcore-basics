using AspNetRunBasicRealWorld.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetRunBasicRealWorld.Data
{
    public class AspnetRunContext : DbContext
    {
        public AspnetRunContext(DbContextOptions<AspnetRunContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
