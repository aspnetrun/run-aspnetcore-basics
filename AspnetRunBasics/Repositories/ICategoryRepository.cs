using AspnetRunBasics.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRunBasics.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
