using System;
using System.Threading.Tasks;
using AspnetRunBasics.Entities;
using AspnetRunBasics.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspnetRunBasics
{
    public class CartModel : PageModel
    {
        private readonly ICartRepository _cartRepository;

        public CartModel(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository ?? throw new ArgumentNullException(nameof(cartRepository));
        }

        public Entities.Cart Cart { get; set; } = new Entities.Cart();
        public decimal TotalPrice { get; set; } = 0;

        public async Task<IActionResult> OnGetAsync()
        {
            Cart = await _cartRepository.GetCartByUserName("test");
            CalculateTotalPrice(Cart);

            return Page();
        }

        public async Task<IActionResult> OnPostRemoveToCartAsync(int cartId, int cartItemId)
        {
            await _cartRepository.RemoveItem(cartId, cartItemId);
            return RedirectToPage();
        }

        private void CalculateTotalPrice(Cart cart)
        {
            foreach (var item in cart.Items)
            {
                TotalPrice += item.Price * item.Quantity;
            }
        }
    }
}