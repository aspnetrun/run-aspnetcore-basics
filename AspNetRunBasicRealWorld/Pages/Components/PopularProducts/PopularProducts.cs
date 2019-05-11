using AspNetRunBasicRealWorld.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetRunBasicRealWorld.Pages.Components.PopularProducts
{
    public class PopularProducts : ViewComponent
    {
        private readonly IProductRepository _productRepository;

        public PopularProducts(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }      

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var productList = await _productRepository.GetProductListAsync();
            var countedProducts = productList.Take(count);

            return View(countedProducts);
        }
    }
}
