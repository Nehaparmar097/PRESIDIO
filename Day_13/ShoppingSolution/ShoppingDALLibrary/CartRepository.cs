using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDALLibrary
{
    public class CartRepository:AbstractRepository<int,Cart>
    {
        public override async Task<Cart> Delete(int key)
        {
            Cart cart = await GetByKey(key);
            if (cart != null)
            {
                items.Remove(cart);
            }
            return cart;
        }


        public override Task<Cart> GetByKey(int key)
        {


            Cart product = items.FirstOrDefault(p => p.Id == key);
            return Task.FromResult(product);
            

        }
        public override async Task<Cart> Update(Cart item)
        {
            Cart cart = await GetByKey(item.Id);
            if (cart != null)
            {
                cart = item;
            }
            return cart;
        }


    }
}

