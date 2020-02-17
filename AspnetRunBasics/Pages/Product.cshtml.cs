using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetRunBasics.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspnetRunBasics
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


        [BindProperty(SupportsGet = true)]
        public string SelectedCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? categoryId)
        {
            CategoryList = await _productRepository.GetCategories();

            if (categoryId.HasValue)
            {
                ProductList = await _productRepository.GetProductByCategoryAsync(categoryId.Value);
                SelectedCategory = CategoryList.FirstOrDefault(c => c.Id == categoryId.Value)?.Name;
            }
            else
            {
                ProductList = await _productRepository.GetProductListAsync();
            }

            return Page();
        }
    }
}