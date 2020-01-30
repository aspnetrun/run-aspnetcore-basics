using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetRunBasicRealWorld.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetRunBasicRealWorld
{
    public class ProductModel : PageModel
    {
        private readonly IProductRepository _productRepository;

        public ProductModel(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public IEnumerable<Entities.Category> CategoryList { get; set; } = new List<Entities.Category>();
        public IEnumerable<Entities.Product> ProductList { get; set; } = new List<Entities.Product>();

        public async Task<IActionResult> OnGetAsync(int? categoryId)
        {
            CategoryList = await _productRepository.GetCategories();
            ProductList = await _productRepository.GetProductByNameAsync(string.Empty);
            // ProductList = await _productRepository.GetProductByCategoryIdAsync(categoryId.Value);

            return Page();
            
        }
    }
}