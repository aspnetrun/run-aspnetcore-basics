using System.Collections.Generic;
using System.Linq;

namespace AspnetRunBasics.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public decimal TotalPrice
        {
            get
            {
                return Items.Sum(item => item.Price * item.Quantity);
            }
        }
    }
}
