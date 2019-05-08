using AspNetRunBasicRealWorld.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetRunBasicRealWorld.Data
{
    public class AspnetRunContext : IdentityDbContext
    {
        public AspnetRunContext(DbContextOptions<AspnetRunContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
