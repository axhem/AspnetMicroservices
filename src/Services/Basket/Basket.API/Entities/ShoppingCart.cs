using System.Collections.Generic;
using System.Linq;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }
        
        public ShoppingCart(string username)
        {
            Username = username;
        }

        public string Username { get; set; }

        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in Items)
                {
                    totalprice += item.Price * item.Quantity;
                }

                return totalprice;
            }
        }

        public ShoppingCartItem GetItem(string productId)
        {
            return Items.FirstOrDefault(x => x.ProductId == productId);
        }
        

    }
}