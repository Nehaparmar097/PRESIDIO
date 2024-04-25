using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public interface IShopping
    {
        void AddProductToCart(int cartId, int productId, int quantity);
        double CalculateTotal(int cartId);
        void ApplyDiscounts(int cartId);
    }
}
