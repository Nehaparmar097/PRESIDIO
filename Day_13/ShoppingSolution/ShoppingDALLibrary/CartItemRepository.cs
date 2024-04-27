using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDALLibrary
{
    public class CartItemRepository:AbstractRepository<int ,CartItem>
    {
        public override Task<CartItem> GetByKey(int key)
        {
            CartItem product = items.FirstOrDefault(p => p.CartId == key);
            return Task.FromResult(product);
        }
        public override async Task<CartItem> Delete(int key)
        {
            CartItem cartitem = await GetByKey(key);
            if (cartitem != null)
            {
                items.Remove(cartitem);
            }
            return cartitem;
        }



        public override Task<CartItem> Update(CartItem item)
        {
            CartItem product = items.FirstOrDefault(p => p.CartId == item.CartId);
            if (product != null)
            {
                // Update properties of the existing product
                product = item;
            }
            return Task.FromResult(product);
        }
    }
}

