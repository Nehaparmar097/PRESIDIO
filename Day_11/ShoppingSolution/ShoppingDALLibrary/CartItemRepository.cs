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
        public override CartItem Delete(int key)
        {
            CartItem cartitem = GetByKey(key);
            if (cartitem != null)
            {
                items.Remove(cartitem);
            }
            return cartitem;
        }

        public override CartItem GetByKey(int key)
        {


            CartItem product = items.FirstOrDefault(p => p.CartId == key);
            return product;

        }
        public override CartItem Update(CartItem item)
        {
            /*   CartItem cartitem = GetByKey(item.CartId);
               if (cartitem != null)
               {
                   cartitem = item;
               }
               return cartitem;*/
            CartItem product = items.FirstOrDefault(p => p.CartId == item.CartId);
            product = item;
            return product;
        }
    }
}

